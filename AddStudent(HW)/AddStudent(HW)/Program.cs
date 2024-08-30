using AddStudent_HW_;

GroupMate group=new GroupMate(5);

group.AddStudent(new Student("Mahir", "Abbasov", 25));
group.AddStudent(new Student("Eliriza", "Quluzade", 18));
group.AddStudent(new Student("Ekber", "Eliyev", 24));
group.AddStudent(new Student("Tural", "Abasquliyev", 35));
group.Sort();
group.ShowStudents();
