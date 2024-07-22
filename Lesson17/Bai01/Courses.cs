namespace Bai01;

class Courses
{
    public int courseId;
    public string courseName;
    public string courseSemester;

    public Courses() { }
    public Courses(int _courseID, string _courseName, string _courseSemester)
    {
        this.courseId = _courseID;
        this.courseName = _courseName;
        this.courseSemester = _courseSemester;
    }

    public void ViewCorses() { }
    public void ViewCorsesString() { }
    public void RegisterStudent() { }
    public void BrowseStudent() { }
}