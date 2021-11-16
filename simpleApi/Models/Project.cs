using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simpleApi.Models
{
    public class Project
    {
        /*
         *  constructor(
        public id?:number,
        public name?:string,
        public description?:string,
        public tasks?: Task[],
        public categoryId?:number
    ){}
         */

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Task> Tasks { get; set; }
        public int CategoryId { get; set; }
    }
}
