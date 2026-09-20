using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutApp.Model
{
    public class Logic
    {
        private List<Workout> workouts;
        private int nextid;
        public Logic()
        {
            workouts = new List<Workout>();
            nextid = 1;

        }
        public Workout CreateWorkout(string exercise, string type, int sets, int reps, double weights, DateTime date)
        {
            if (string.IsNullOrWhiteSpace(exercise))
                throw new ArgumentNullException("название упражнения не может быть пустым");
            if (sets <= 0 || reps <= 0)
                throw new ArgumentNullException("повторения и подходы должны быть больше 0");
            if (weights < 0)
                throw new ArgumentNullException("вес не может быть отрицательным");
            var workout = new Workout(nextid++, exercise, type, sets, reps, weights, date);
            workouts.Add(workout);
            return workout;
        }
        public List<Workout> GetWorkouts()
        {
            return workouts.ToList();

        }
        public Workout GetWorkoutByid(int id)
        {
            return workouts.FirstOrDefault(w => w.id == id);

        }
        public bool UpdateWorkout(int id, string exercise, string type, int sets, int reps, double weights, DateTime date)
        {
            var workout = GetWorkoutByid(id);
            if (workout == null) return false;
            if (string.IsNullOrWhiteSpace(exercise))
                throw new ArgumentException("Название упражнения не может быть пустым");
            if (sets <= 0 || reps <= 0)
                throw new ArgumentNullException("подходы и повторения должны быть больше 0");
            workout.exercise = exercise;
            workout.type = type;
            workout.sets = sets;
            workout.reps = reps;
            workout.weights = weights;
            workout.date = date;
            return true;
        }
        public bool DeleteWorkout(int id)
        {
            var workout = GetWorkoutByid(id);
            if (workout == null) return false;
            workouts.Remove(workout);
            return true;
        }
        public double GetTotalLiftedWeights()
        {
            return workouts.Sum(w => w.weights * w.reps * w.sets);
        }
        public Dictionary<string, int> GetWorkoutsCountBytype()
        {
            return workouts
                .GroupBy(w => w.type)
                .ToDictionary(g => g.Key, g => g.Count());
        }
    }
}