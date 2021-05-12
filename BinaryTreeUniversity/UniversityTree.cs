using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeUniversity
{
    class UniversityTree
    {
        public PositionNode Root;

        public void CreatePosition(PositionNode Parent, Position positionTocreate, string parentPositionName)
        {
            PositionNode newNode = new PositionNode();
            newNode.Position = positionTocreate;

            if (Root == null)
            {
                Root = newNode;
                return;
            }

            if (Parent == null)
            {
                return;
            }
            if (Parent.Position.Name == parentPositionName)
            {
                if (Parent.Left == null)
                {
                    Parent.Left = newNode;
                    return;

                }

                Parent.Right = newNode;
                return;
            }
            CreatePosition(Parent.Left, positionTocreate, parentPositionName);
            CreatePosition(Parent.Right, positionTocreate, parentPositionName);
        }
        public void PrintTree(PositionNode from)
        {
            if (from == null)
            {
                return;
            }

            Console.WriteLine($"{from.Position.Name} : ${from.Position.Salary}");
            PrintTree(from.Left);
            PrintTree(from.Right);
        }

        public float AddSalaries(PositionNode from)
        {
            if (from == null)
            {
                return 0;
            }

            return from.Position.Salary + AddSalaries(from.Left) + AddSalaries(from.Right);

        }
        //SEGUNDA PARTE DEL EJERCICIO 
        // Punto 1 Obtenga el salario más largo (sin incluir el DIRECTOR). 
        public float longestSalary(PositionNode from)
        {
            if (from == null)
            {
                return 0;
            }
            if (from.Position.Name == "Rector")
            {
                if (longestSalary(from.Left) > longestSalary(from.Right))
                {
                    return longestSalary(from.Left);
                }
                else
                {
                    return longestSalary(from.Right);
                }
            }
            else
            {
                if (longestSalary(from.Left) > from.Position.Salary || longestSalary(from.Right) > from.Position.Salary)
                {
                    if (longestSalary(from.Left) > longestSalary(from.Right))
                    {
                        return longestSalary(from.Left);
                    }
                    else
                    {
                        return longestSalary(from.Right);
                    }
                }
                else
                {
                    return from.Position.Salary;
                }
            }
        }

        //Suma de la cantidad de personas que tiene el árbol
        public float amountPersonal(PositionNode from)
        {
            if (from == null)
            {
                return 0;
            }
            return 1 + amountPersonal(from.Left) + amountPersonal(from.Right);
        }

        //punto 2 Calcule el salario promedio, 

        public float averageSalaries(PositionNode from)
        {
            return AddSalaries(from) / amountPersonal(from);
        }

        // Punto 3 ¿Cuánto es el salario dado a un puesto determinado? 
        public float salaryEmployee(PositionNode from, string name)
        {
            if (from == null)
            {
                return 0;
            }
            if (from.Position.Name == name)
            {
                return from.Position.Salary;
            }
            return salaryEmployee(from.Left, name) + salaryEmployee(from.Right, name);
        }

        //Punto 4 Agregue el impuesto al salario (porcentaje 0% -30%), cada puesto tiene un porcentaje de impuesto diferente, 
        public float taxSalary(PositionNode from)
        {
            if (from == null)
            {
                return 0;
            }
            return (from.Position.Salary * Convert.ToSingle(from.Position.Tax)) + taxSalary(from.Left) + taxSalary(from.Right);
        }
    }
}
  

