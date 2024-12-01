class Parameters {

    // main parameters
    public readonly int POPULATION_SIZE = 100_000;
    public readonly int TOURNAMENT_SIZE = 5; 
    public readonly int MAX_GENERATIONS = 100;


    // probability parameters
    public readonly double CHANCE_OF_NODE_MUTATING = 0.05;
    public readonly double CROSS_OVER_PROBABILITY = 0.9;


    // selections method - parameters
    public readonly TournamentMethod TOURNAMENT_METHOD = TournamentMethod.BEST_RANDOM;
    public readonly CrossoverMethod CROSSOVER_METHOD = CrossoverMethod.ONE_POINT;


    public enum TournamentMethod {
        BEST_RANDOM, ROULETEE
    }

    public enum CrossoverMethod {
        ONE_POINT, TWO_POINT, ONE_POINT_NORMAL, TWO_POINT_NORMAL
    }
}