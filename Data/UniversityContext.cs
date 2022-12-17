using Microsoft.EntityFrameworkCore;
using tp4.Models;
using System.Diagnostics;

namespace tp4.Data;

public class UniversityContext : DbContext {
    private static UniversityContext _universitycontextinstance;
    public static UniversityContext universitycontextinstance{
        get
        {
             if(_universitycontextinstance==null)
             _universitycontextinstance=Instantiate_UniversityContext();
             return _universitycontextinstance;
        }
        
        
    }
    private UniversityContext(DbContextOptions o) : base(o){}
    private static UniversityContext Instantiate_UniversityContext()
    {
        var optionBuilder = new DbContextOptionsBuilder<UniversityContext>();
        optionBuilder.UseSqlite("Data Source=C:/Users/user/Documents/vscode_proj/charpproj/tp4/databasetp4.db");
        Debug.WriteLine("instantiation 111111");
        return new UniversityContext(optionBuilder.Options);
    }
   public DbSet<Student> Student {get; set;} 
}

//Data Source=C:/Users/user/Documents/vscode proj/charpproj/tp2sqlite/src/database/TP3.db
//injection porvider    dependency enjection