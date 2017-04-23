﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace RecipeApp2
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using System.Data.Entity.Core.Objects;
using System.Linq;


public partial class Recipe2Entities : DbContext
{
    public Recipe2Entities()
        : base("name=Recipe2Entities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Recipe> Recipes { get; set; }


    public virtual int DeleteTodo(Nullable<int> iD)
    {

        var iDParameter = iD.HasValue ?
            new ObjectParameter("ID", iD) :
            new ObjectParameter("ID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteTodo", iDParameter);
    }


    public virtual int InsertTodo(string name, string description, Nullable<System.DateTime> todoDate)
    {

        var nameParameter = name != null ?
            new ObjectParameter("Name", name) :
            new ObjectParameter("Name", typeof(string));


        var descriptionParameter = description != null ?
            new ObjectParameter("Description", description) :
            new ObjectParameter("Description", typeof(string));


        var todoDateParameter = todoDate.HasValue ?
            new ObjectParameter("TodoDate", todoDate) :
            new ObjectParameter("TodoDate", typeof(System.DateTime));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertTodo", nameParameter, descriptionParameter, todoDateParameter);
    }


    public virtual ObjectResult<SelectTodo_Result> SelectTodo(Nullable<System.DateTime> todoDate)
    {

        var todoDateParameter = todoDate.HasValue ?
            new ObjectParameter("TodoDate", todoDate) :
            new ObjectParameter("TodoDate", typeof(System.DateTime));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectTodo_Result>("SelectTodo", todoDateParameter);
    }


    public virtual int UpdateTodo(Nullable<int> iD, string name, string description, Nullable<System.DateTime> todoDate)
    {

        var iDParameter = iD.HasValue ?
            new ObjectParameter("ID", iD) :
            new ObjectParameter("ID", typeof(int));


        var nameParameter = name != null ?
            new ObjectParameter("Name", name) :
            new ObjectParameter("Name", typeof(string));


        var descriptionParameter = description != null ?
            new ObjectParameter("Description", description) :
            new ObjectParameter("Description", typeof(string));


        var todoDateParameter = todoDate.HasValue ?
            new ObjectParameter("TodoDate", todoDate) :
            new ObjectParameter("TodoDate", typeof(System.DateTime));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateTodo", iDParameter, nameParameter, descriptionParameter, todoDateParameter);
    }

}

}

