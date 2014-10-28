using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Test
    {
        public class Question
        {
            private class Variant
            {
                public string Text
                {
                    get;
                    set;
                }

                public string Image
                {
                    get;
                    set;
                }

                public bool Validation
                {
                    get;
                    set;
                }

                public Variant(string Text, bool Validation, string Image)
                {
                    this.Text = Text;
                    this.Validation = Validation;
                    this.Image = Image;
                }

            }

            public string Name
            {
                get;
                private set;
            }

            public string Text
            {
                get;
                private set;
            }

            public string Image
            {
                get;
                private set;
            }

            private List<Variant> Variants;

            public Question(string Name, string Text, string Image)
            {
                this.Name = Name;
                this.Text = Text;
                this.Image = Image;
            }
        }

        public string Name
        {
            get;
            set;
        }

        public Discipline Discipline
        {
            get;
            set;
        }

        public List<Question> Questions
        {
            get;
            set;
        }

        public List<Student> Students
        {
            get;
            set;
        }

        public Test(string Name, Discipline Discipline)
        {
            this.Name = Name;
            this.Discipline = Discipline;
        }

    }
}