public static class mokeTypes
{
    public enum mokeType {Normal, Fire, Water, Electric, Grass, Ice, Fighting, Poison, Ground, Flying, Psychic, Bug, Rock, Ghost, Dragon, Dark, Steel, Fairy};
    public static double TypeBonus(mokeType typeAttack, mokeType typeDefend)
    {
        switch (typeAttack)
        {
            case mokeType.Normal:
                switch (typeDefend)
                {
                    case mokeType.Rock:
                        return 0.5;
                    case mokeType.Ghost:
                        return 0;
                    case mokeType.Steel:
                        return 0.5;
                    default:
                        return 1;
                }
            case mokeType.Electric:
                switch (typeDefend)
                {
                    case mokeType.Water:
                        return 2;
                    case mokeType.Electric:
                        return 0.5;
                    case mokeType.Grass:
                        return 0.5;
                    case mokeType.Ground:
                        return 0;
                    case mokeType.Flying:
                        return 2;
                    case mokeType.Dragon:
                        return 0.5;
                    default:
                        return 1;
                }
            default:
                return 1;
        }
    }
}
