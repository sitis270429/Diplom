using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIsualizationAndAnaliz
{
    public class Student
    {
        public string FullName { get; private set; }
        public string Email { get; private set; }
        public double Score { get; private set; }
        //public List<double> Scores { get; private set; }
        public Student(string fullName, string email, double score) {
            FullName = fullName;
            Email = email;
            Score = score;
        }
        public Student(string fullName, string email) {
            FullName = fullName;
            Email = email;
        }
        public string Show() {
            return $"ФИО: { FullName }, Почта: {Email},  Балл: { Score }";
        }
    }
}
