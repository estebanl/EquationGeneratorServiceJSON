using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EquationGeneratorServiceJSON
{
    [DataContract]
    public class Equation
    {
        [DataMember]
        public int Left { get; set; }
        [DataMember]
        public int Right { get; set; }
        [DataMember]
        public int Result { get; set; }
        [DataMember]
        public string Operation { get; set; }

        public Equation() : this(0, 0, "add")
        {
            
        }

        public Equation(int leftValue, int rightValue, string type)
        {
            Left = leftValue;
            Right = rightValue;

            switch (type)
            {
                case "add":
                    Result = Left + Right;
                    Operation = "+";
                    break;

                case "subtract":
                    Result = Left - Right;
                    Operation = "-";
                    break;

                case "multiply":
                    Result = Left*Right;
                    Operation = "*";
                    break;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} = {4}", Left, Operation, Right, Result);
        }

        [DataMember]
        private string LeftHandSide
        {
            get
            {
                return string.Format("{0}{1}{2}", Left, Operation, Right);
            }
            set
            {

            }
        }

        [DataMember]
        private string RightHandSide
        {
            get
            {
                return Result.ToString();
            }
            set
            {

            }
        }
    }
}
