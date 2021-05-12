using System;

namespace BinaryTreeUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
            Position rectorPosition = new Position();
            rectorPosition.Name = "rector";
            rectorPosition.Salary = 1000;
            rectorPosition.Tax = 0.15;

            Position vicFinanPosition = new Position();
            vicFinanPosition.Name = "vecerector financiero";
            vicFinanPosition.Salary = 750;
            vicFinanPosition.Tax = 0.10;

            Position contadorPosition = new Position();
            contadorPosition.Name = "contador";
            contadorPosition.Salary = 500;
            contadorPosition.Tax = 0.05;


            Position jefeFinPosition = new Position();
            jefeFinPosition.Name = "jefe financiero";
            jefeFinPosition.Salary = 610;
            jefeFinPosition.Tax = 0.12;

            Position secreFin1Position = new Position();
            secreFin1Position.Name = "secretaria financiera 1 ";
            secreFin1Position.Salary = 350;
            secreFin1Position.Tax = 0.08;

            Position secreFin2Position = new Position();
            secreFin2Position.Name = "secretaria financiera 1 ";
            secreFin2Position.Salary = 310;
            secreFin2Position.Tax = 0.03;

            Position vicAcademicPosition = new Position();
            vicAcademicPosition.Name = "vicerector academico";
            vicAcademicPosition.Salary = 780;
            vicAcademicPosition.Tax = 0.18;

            Position jefeRegisPosition = new Position();
            jefeRegisPosition.Name = "jefe registro";
            jefeRegisPosition.Salary = 640;
            jefeRegisPosition.Tax = 0.20;

            Position secreRegis2Position = new Position();
            secreRegis2Position.Name = "secretaria de registro 2";
            secreRegis2Position.Salary = 360;
            secreRegis2Position.Tax = 0.10;

            Position secreRegis1Position = new Position();
            secreRegis1Position.Name = "secretaria de resgistro 1 ";
            secreRegis1Position.Salary = 400;

            Position asisten2Position = new Position();
            asisten2Position.Name = "asistente 2";
            asisten2Position.Salary = 170;
            asisten2Position.Tax = 0.09;

            Position asisten1Position = new Position();
            asisten1Position.Name = "asistente 1";
            asisten1Position.Salary = 250;
            asisten1Position.Tax = 0.15;

            Position mensajeroPosition = new Position();
            mensajeroPosition.Name = "mensajero";
            mensajeroPosition.Salary = 90;
            mensajeroPosition.Tax = 0.05;

            UniversityTree universityTree = new UniversityTree();
            universityTree.CreatePosition(null, rectorPosition, null);
            universityTree.CreatePosition(universityTree.Root, vicFinanPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, contadorPosition, vicFinanPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secreFin1Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secreFin2Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeFinPosition, vicFinanPosition.Name);
            universityTree.CreatePosition(universityTree.Root, vicAcademicPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeRegisPosition, vicAcademicPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secreRegis2Position, jefeRegisPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secreRegis1Position, jefeRegisPosition.Name);
            universityTree.CreatePosition(universityTree.Root, asisten2Position, secreRegis1Position.Name);
            universityTree.CreatePosition(universityTree.Root, mensajeroPosition, asisten2Position.Name);
            universityTree.CreatePosition(universityTree.Root, asisten1Position, secreRegis1Position.Name);
            universityTree.CreatePosition(universityTree.Root, asisten1Position, secreRegis1Position.Name);



            universityTree.PrintTree(universityTree.Root);

            float totalSalary = universityTree.AddSalaries(universityTree.Root);
            Console.WriteLine($"Total salaries: {totalSalary}");

            //Console.ReadLine();

            //Punto 1 Obtenga el salario más largo (sin incluir "el principal". 
            float longestSalary = universityTree.longestSalary(universityTree.Root);
            Console.WriteLine($"the longest salary is: {longestSalary}");

            //Punto 2 Salarios medios. 
            float averageSalaries = universityTree.averageSalaries(universityTree.Root);
            Console.WriteLine($"Average Salaries: {averageSalaries}");

            //Punto 3 ¿Cuánto es el salario dado a un puesto determinado, 

            Console.Write("Insert Name: ");
            string nametemp = Console.ReadLine();
            float salaryEmployee = universityTree.salaryEmployee(universityTree.Root, nametemp);
            Console.WriteLine($"the salary of {nametemp} is: {salaryEmployee}");

            //Punto 4 Agregue el impuesto al salario (porcentaje 0% -30%), cada puesto tiene un porcentaje de impuesto diferente, 
            float taxSalary = universityTree.taxSalary(universityTree.Root);
            Console.WriteLine($"the sumatory tax is {taxSalary}");
        }
    }
}
