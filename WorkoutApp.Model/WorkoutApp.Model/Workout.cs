using System;

namespace WorkoutApp.Model
{
    public class Workout
    {
        public int id { get; set; }
        public string exercise { get; set; }
        public string type { get; set; }
        public int sets { get; set; }
        public int reps { get; set; }
        public double weights { get; set; }
        public DateTime date { get; set; }

        public Workout() { }

        public Workout(int id, string exercise, string type,
                       int sets, int reps, double weights, DateTime date)
        {
            this.id = id;
            this.exercise = exercise;
            this.type = type;
            this.sets = sets;
            this.reps = reps;
            this.weights = weights;   // ← теперь параметр и поле называются одинаково
            this.date = date;
        }

        public override string ToString()
        {
            return $"[{id}] {exercise} ({type}) | " +
                   $"Подходы: {sets}, Повторы: {reps}, Вес: {weights} кг | " +
                   $"Дата: {date:dd.MM.yyyy}";
        }
    }
}
