using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MenegerPassword.SQLite
{
    public class Repos
    {
        //public Type type = new Type();
        readonly SQLiteConnection db;
        public Repos(string connectionString)
        {
            db = new SQLiteConnection(connectionString);
            db.CreateTable<User>();
            db.CreateTable<Account>();
            db.CreateTable<Type>();

        }
        public IEnumerable<Account> GetAccounts()
        {
            return db.Table<Account>().ToList();
        }
        public Account GetAccount(int id)
        {
            return db.Table<Account>()
                                .Where(i => i.ID == id)
                                .FirstOrDefault();
        }
        public int SaveAccount(Account account)
        {
            if (account.ID != 0)
            {
                return db.Update(account);
            }
            else
            {
                return db.Insert(account);
            }
        }
        public int DeleteAccount(int id)
        {
            return db.Delete<Account>(id);
        }
        public int SaveUser(User user)
        {
            if (user.ID != 0)
            {
                return db.Update(user);
            }
            else
            {
                return db.Insert(user);
            }
        }
        public int DeleteUser(int id)
        {
            return db.Delete<User>(id);
        }
        public IEnumerable<User> GetUsers()
        {
            return db.Table<User>().ToList();
        }
        public User GetUser(int id)
        {
            return db.Table<User>()
                                .Where(i => i.ID == id)
                                .FirstOrDefault();
        }
        public int SaveType(Type type)
        {
            if (type.ID != 0)
            {
                return db.Update(type);
            }
            else
            {
                return db.Insert(type);
            }
        }
        public int DeleteType(int id)
        {
            return db.Delete<Type>(id);
        }
        public IEnumerable<Type> GetTypes()
        {
            return db.Table<Type>().ToList();
        }
        public Type GetType(int id)
        {
            return db.Table<Type>()
                                .Where(i => i.ID == id)
                                .FirstOrDefault();
        }
        //public bool IsNewUser()
        //{
        //    return App.Repos.GetUsers().FirstOrDefault() == null;
        //}

    }
}
