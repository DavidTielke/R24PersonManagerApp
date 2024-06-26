﻿using ConsoleClient.DataClasses;

namespace ConsoleClient;

class PersonManager
{
    private PersonRepository _repository;

    public PersonManager()
    {
        _repository = new PersonRepository();
    }

    public IQueryable<Person> GetAllChildren()
    {
        var children = _repository.Query().Where(p => p.Age < 18);
        return children;
    }

    public IQueryable<Person> GetAllAdults()
    {
        var adults = _repository.Query().Where(p => p.Age >= 18);
        return adults;
    }

    public void Copy()
    {
        var foo = new PersonUtils();
    }
}

class PersonUtils
{
    public void Foo()
    {

    }
}