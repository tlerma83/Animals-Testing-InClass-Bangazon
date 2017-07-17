using System;
using Xunit;
using Animals;

namespace Animals.Tests
{
    public class AnimalShould
    {
        private Animal _animal;

        private Dog _dog;

        public AnimalShould()
        {
            _animal = new Animal("George");
            _dog = new Dog("LunchBox");
        }

        [Fact]
        public void HaveRightNamePropertyValue()
        {
            Assert.Equal(_animal.Name, "George");
        }

        [Fact]
        public void SetSpeciesMethodShouldSetSpeciesProperty()
        {
            // string species = _animal.SetSpecies("German Shepherd");
            // Assert.Equal(species, "German Shepherd");

            // Setting the species for animal class, dog will inherit this
            _animal.SetSpecies("German Shepherd");
            Assert.Equal(_animal.Species, "German Shepherd");

            _dog.SetSpecies("Carolina Lab");
            Assert.Equal(_dog.Species, "Carolina Lab");
        }


        [Fact]
        public void HaveWalkingSpeedSetWithWalkMethod()
        {
            _animal.Walk(30);
            Assert.Equal(_animal.WalkingSpeed, 30);

            _dog.Walk(0.75);
            Assert.Equal(_dog.WalkingSpeed, 0.75);
            
        }

        [Fact]
        public void InstanceShouldBeOfCorrectType()
        {
            Assert.IsType<Animal>(_animal);
            Assert.IsType<Dog>(_dog);
        }
    }
}
