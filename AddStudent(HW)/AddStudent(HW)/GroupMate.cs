namespace AddStudent_HW_
{
    internal class GroupMate
    {
        public Student[]students;
        public int count;

        public GroupMate(int size)
        {
            students = new Student[size];
            count = 0;
        }
        public void AddStudent(Student student)
        {
            if (count < students.Length)
            {
                students[count] = student;
                count++;
                

            }
            else
            {
                Console.WriteLine("Yeni telebe elave etmek ugursuz oldu");

            }
        }

        public void Sort()
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (students[j] > students[j + 1]) 
                    {
                        Student T = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = T;
                    }
                }
            }
        }
        public void ShowStudents()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(students[i]);
                
            }
        }
    }
}





