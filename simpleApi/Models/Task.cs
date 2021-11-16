using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simpleApi.Models
{
    public class Task
    {
        /*
         *     constructor(public id?: number, 
                public name?: string,
                public description?:string,
                public expectedDate?: Date,
                public isDone?:boolean){
         */
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ExpectedDate { get; set; }
        public bool IsDone { get; set; }

    }
}
