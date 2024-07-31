﻿using RV24.PMA.CrossCutting.DataClasses;

namespace RV24.PMA.Logic.Domain.PersonManagement;

public interface IPersonManager
{
    void Add(Person person);
    IQueryable<Person> GetAllChildren();
    IQueryable<Person> GetAllAdults();
}