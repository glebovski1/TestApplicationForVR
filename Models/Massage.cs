using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplicationForVR.Models
{
    [Serializable]
    public class Massage : IEquatable<Massage>
    {
        public DateTime TimeOfCreation { get; set; }

        public string Text { get; set; }

        public int UserId { get; set; }
        public Massage(int userId, string text)
        {
            UserId = userId;
            TimeOfCreation = DateTime.UtcNow;
            Text = text;
        }
        public Massage()
        {
            TimeOfCreation = DateTime.UtcNow;
        }

        public bool Equals(Massage other)
        {
            if (other == null)
            {
                return false;
            }
            if (this.Text == other.Text && this.UserId == other.UserId && this.TimeOfCreation == other.TimeOfCreation)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //public override bool Equals(object obj) => Equals(obj as Massage);
        public override int GetHashCode() => (TimeOfCreation, Text, UserId).GetHashCode();
    }
}
