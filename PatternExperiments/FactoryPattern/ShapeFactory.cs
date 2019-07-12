using PatternExperiments.FactoryPattern.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExperiments.FactoryPattern
{
    public class ShapeFactory
    {
        public Shape GetShape(String shapeType)
        {
            Shape result= new Circle();

            if (string.IsNullOrWhiteSpace(shapeType))
            {
                return null;

            }

            switch (shapeType)
            {
                case "Circle":
                    result= new Circle();
                    break;
                case "Rectangle":
                    result= new Circle();
                    break;
                case "Square":
                    result= new Circle();
                    break;
        }

            return result;
    }
}
