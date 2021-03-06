﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmploidutempsWS
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class C_BASE : DbContext
    {
        public C_BASE()
            : base("name=C_BASE")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C_Cours> Les_Cours { get; set; }
        public virtual DbSet<C_Presence> Les_Presence { get; set; }
        public virtual DbSet<C_Utilisateurs> Les_Utilisateurs { get; set; }
    
        public virtual int ADD_PRESENCE(Nullable<int> id_User, Nullable<int> id_Cours_choisi)
        {
            var id_UserParameter = id_User.HasValue ?
                new ObjectParameter("Id_User", id_User) :
                new ObjectParameter("Id_User", typeof(int));
    
            var id_Cours_choisiParameter = id_Cours_choisi.HasValue ?
                new ObjectParameter("Id_Cours_choisi", id_Cours_choisi) :
                new ObjectParameter("Id_Cours_choisi", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ADD_PRESENCE", id_UserParameter, id_Cours_choisiParameter);
        }
    
        public virtual ObjectResult<Get_Presence_Result> Get_Presence(Nullable<int> id_Cours)
        {
            var id_CoursParameter = id_Cours.HasValue ?
                new ObjectParameter("id_Cours", id_Cours) :
                new ObjectParameter("id_Cours", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Get_Presence_Result>("Get_Presence", id_CoursParameter);
        }
    
        public virtual ObjectResult<C_Cours> Get_all_cours1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<C_Cours>("Get_all_cours1");
        }
    
        public virtual ObjectResult<C_Cours> Get_all_cours1(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<C_Cours>("Get_all_cours1", mergeOption);
        }
    
        public virtual int ADD_UTILISATEURS(string nom, string prenom)
        {
            var nomParameter = nom != null ?
                new ObjectParameter("Nom", nom) :
                new ObjectParameter("Nom", typeof(string));
    
            var prenomParameter = prenom != null ?
                new ObjectParameter("Prenom", prenom) :
                new ObjectParameter("Prenom", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ADD_UTILISATEURS", nomParameter, prenomParameter);
        }
    
        public virtual int DELETE_ALL_PRESENCE()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DELETE_ALL_PRESENCE");
        }
    
        public virtual ObjectResult<C_Utilisateurs> Get_All_USERS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<C_Utilisateurs>("Get_All_USERS");
        }
    
        public virtual ObjectResult<C_Utilisateurs> Get_All_USERS(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<C_Utilisateurs>("Get_All_USERS", mergeOption);
        }
    }
}
