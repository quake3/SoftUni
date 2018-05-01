namespace InfernoInfinity.Interfaces
{

    using Enums;

    public interface IGem
    {
        int Strength { get; set; }
        int Agility { get; set; }
        int Vitality { get; set; }
        GEM_QUALITY GemQuality { get; set; }
    }

}
