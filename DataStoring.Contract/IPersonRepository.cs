﻿using RV24.PMA.CrossCutting.DataClasses;

namespace RV24.PMA.Data.DataStoring;

public interface IPersonRepository
{
    IQueryable<Person> Query();
    void Insert(Person person);
}