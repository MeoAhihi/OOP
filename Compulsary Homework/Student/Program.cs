var sv1 = new Student(1, "Ly Vi Phong", 9.5f, 8.0f); 
var sv2 = new Student(2, "Ta Ngoc Bich Phuong", 9.0f, 8.5f);
var sv3 = new Student();
System.Console.Write("Ma so sv: "); sv3.setId(int.Parse(Console.ReadLine()));
System.Console.Write("Ten sv: "); sv3.setName(Console.ReadLine());
System.Console.Write("Diem ly thuyet: "); sv3.setTheory(float.Parse(Console.ReadLine()));
System.Console.Write("Diem thuc hanh: "); sv3.setPractice(float.Parse(Console.ReadLine()));
sv3 = new Student(4, "Meoahihi", 6.0f, 9);

Student.title();
sv1.toString();
sv2.toString();
sv3.toString();
Student.end();