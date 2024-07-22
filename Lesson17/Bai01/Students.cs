namespace Bai01;

class Students : Courses
{
    public int studentId;
    public string studentName;

    public string studentSection { get; set; }
    public string studentSemester { get; set; }
    public Students(){}

    public bool RegisterSectionCourses(string _studentSection)
    {
        return true;
    }

    public void BrowseSectionCourses()
    {

    }

    public void WaitListCourseSection()
    {

    }

    public void EvaluateProgess()
    {
        
    }
}