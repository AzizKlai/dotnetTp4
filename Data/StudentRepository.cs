using System.Linq.Expressions;

using tp4.Models;

namespace tp4.Data{
public class StudentRepository {
    private readonly UniversityContext context;
    public StudentRepository(){
        this.context=UniversityContext.universitycontextinstance;
    }


    public Student Get(Int64 id){
        return context.Student.Find(id);
        //.Find(id);
    }

    public IEnumerable<Student> GetAll(){
        return context.Student.ToList();
    }
    public IEnumerable<Student> Find(Expression<Func<Student,bool>> predicate){

        return context.Student.Where(predicate);
    }
public IEnumerable<Student> StudentsByCourse(String course){

        return context.Student.Where(per=> per.course==course);
    }

    
    public IEnumerable<String> GetAllCourses(){
    return context.Student.Select(per=> per.course).Distinct();
    }

}
}