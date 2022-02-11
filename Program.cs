Parallel.Invoke(
    () => PrintTeacherDetails(),
    () => PrintStudentDetails()
);

static void PrintTeacherDetails()
{
    Singleton fromTeacher = Singleton.GetInstance;
    fromTeacher.PrintDetails("Teacher");
}

static void PrintStudentDetails()
{
    Singleton fromStudent = Singleton.GetInstance;
    fromStudent.PrintDetails("Student");
}