using System;

namespace realexample
{
    // Comon contract to fly and be composed by
    public interface IPlaner
    {
        // Ability to fly
        void Fly();

        // Power of the component
        int Power {get;}
    }
}