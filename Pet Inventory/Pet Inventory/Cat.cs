namespace Pet_Inventory
{
    class Cat : Pet, AnimalMakeSound
    {
        private string _hasWhiskers = string.Empty;

        public void SetWhiskers(string whiskers) => this._hasWhiskers = whiskers;

        public string GetWhiskers()=> this._hasWhiskers;

        public string makeSound => "meow";
        public override string ToString()
        {
            return $"{kind} - {animalName} ({gender}), Owner: {ownerName}, Whiskers: {GetWhiskers()}, Sound: {makeSound}";
        }
    }

            

            }
        

 
