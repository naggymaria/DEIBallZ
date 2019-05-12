﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneticIndividual : Individual {


	GeneticIndividual(int[] topology) : base(topology) {
	}

	public override void Initialize () 
	{
		throw new System.NotImplementedException ();
	}
		
	public override void Crossover (Individual partner, float probability)
	{
		throw new System.NotImplementedException ();
	}

	public override void Mutate (float probability)
	{
		throw new System.NotImplementedException ();
	}

	public override Individual Clone ()
	{
		GeneticIndividual new_ind = new GeneticIndividual(this.topology);

		genotype.CopyTo (new_ind.genotype, 0);
		new_ind.fitness = this.Fitness;
		new_ind.evaluated = false;

		return new_ind;
	}

}
