using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab24
{
    /// <summary>
    /// This is the Abstract Villain Class
    /// </summary>
    public abstract class Villain
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS)
        private string _name;

        // PUBLIC PROPERTIES
        public string Name
        {

            get
            {
                return this._name;
            }

            set
            {
                this._name = value;
            }
        }

        // CONSTRUCTORS ---------------------------------------------

        /// <summary>
        /// This is the main constructor for the Villain class.
        /// It takes one parameter - name (string)
        /// </summary>
        /// <param name="name"></param>
        public Human(string name)
        {
            this.Name = name;
        }

        // PRIVATE METHODS

        // PUBLIC METHODS

        // PUBLIC ABSTRACT METHODS
        public abstract void DisplaySkills();

    }
}
