namespace SemenovNS_31_21.DTO.Student
{
    public record CreateStudentDto(
        string surname,
        string name, 
        string patronymic,
        int age, 
        int groupId
    );
}
