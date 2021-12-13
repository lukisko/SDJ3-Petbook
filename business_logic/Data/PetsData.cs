using System.Collections.Generic;
using System.Linq;
using business_logic.Model;
using Entities;
using System;

namespace business_logic.Data
{
    public class PetsData : IPetsData
    {

        //private string todoFile = "todos.json";
        private IList<Pet> pets;

        /*public void AddPet(Pet pet)
        {
            int max = pets.Max(todo => todo.TodoId);
            pets.TodoId = (++max);
            pets.Add(pet);
            //WriteTodosToFile();
        }

        public void RemoveTodo(int todoId)
        {
            Todo toRemove = todos.First(t => t.TodoId == todoId);
            todos.Remove(toRemove);
            WriteTodosToFile();
        }*/

        public IList<Pet> GetPets()
        {
            List<Pet> tmp = new List<Pet>(pets);
            Console.WriteLine("pets are gonna return!");
            return tmp;
        }

        public PetsData()
        {
            Console.WriteLine("seed is going to run!");
            Seed();
        }

        public Pet AddPet(Pet pet){
            int maxId = pets.Max((pet)=> pet.id);
            pet.id = maxId;
            pets.Add(pet);
            return pet;
        }

        /*private void WriteTodosToFile()
        {
            string todosAsJson = JsonSerializer.Serialize(todos);
            File.WriteAllText(todoFile, todosAsJson);
        }

        public async Task<IList<Todo>> GetTodosAsync()
        {
            List<Todo> tmp = new List<Todo>(todos);
            return tmp;
        }

        public Todo GetTodo(int id)
        {
            Todo tmpTodo = todos.Where(todo => todo.TodoId == id).First();
            return tmpTodo;
        }

        public async Task<IList<Todo>> GetTodosWhere(Func<Todo, bool> filter)
        {
            return todos.Where(filter).ToList();
        }*/

        //Func<> and Action<> delegate for custom

        private void Seed()
        {
            Pet[] petList = {
        new Pet {
            id = 1,
            name = "maw",
            type = "CAT",
            breed = "??"
        },
        new Pet {
            id = 1,
            name = "wof",
            type = "DOG",
            breed = "??"
        },
        new Pet {
            id = 1,
            name = "...",
            type = "FISH",
            breed = "gold fish"
        },
    };
            pets = petList.ToList();
        }
    }
}