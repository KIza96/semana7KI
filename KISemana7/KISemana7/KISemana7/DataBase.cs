using System;
using SQLite;
namespace KISemana7
{
	public interface DataBase
	{
        SQLiteAsyncConnection GetConnection();
    }
}

