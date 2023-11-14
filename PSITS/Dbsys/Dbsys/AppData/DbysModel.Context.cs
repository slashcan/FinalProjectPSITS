﻿

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Dbsys.AppData
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;


public partial class DBSYSEntities : DbContext
{
    public DBSYSEntities()
        : base("name=DBSYSEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public DbSet<Role> Role { get; set; }

    public DbSet<UserAccount> UserAccount { get; set; }

    public DbSet<UserInformation> UserInformation { get; set; }

    public DbSet<vw_all_user_role> vw_all_user_role { get; set; }

    public DbSet<Events> Events { get; set; }

    public DbSet<Misc> Misc { get; set; }


    public virtual int sp_CreateUser(string username, string password, Nullable<int> role, string status, Nullable<int> createdBy)
    {

        var usernameParameter = username != null ?
            new ObjectParameter("username", username) :
            new ObjectParameter("username", typeof(string));


        var passwordParameter = password != null ?
            new ObjectParameter("password", password) :
            new ObjectParameter("password", typeof(string));


        var roleParameter = role.HasValue ?
            new ObjectParameter("role", role) :
            new ObjectParameter("role", typeof(int));


        var statusParameter = status != null ?
            new ObjectParameter("status", status) :
            new ObjectParameter("status", typeof(string));


        var createdByParameter = createdBy.HasValue ?
            new ObjectParameter("createdBy", createdBy) :
            new ObjectParameter("createdBy", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_CreateUser", usernameParameter, passwordParameter, roleParameter, statusParameter, createdByParameter);
    }

}

}
