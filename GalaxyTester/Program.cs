using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

using GalaxySim;
using GalaxySim.Utilities;
using GalaxySim.CoordinateSystems;

namespace GalaxyTester
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo file = new FileInfo("Orion Arm.csv");

            GalacticRegon arm = StarParser.ReadStarChart(file);

            foreach(StarSystem system in arm.StarSystems)
            {
                double mag = system.Location.MagnitudeSquared;
				if (mag < 0.001)
					SetupSolSystem(system);
				else
					BuildRandomSystem(system);
            }
        }

		static void BuildRandomSystem( StarSystem system )
		{

		}

		static void SetupSolSystem(StarSystem system)
		{
			Random rand = new Random();

			StarSystem.Planet world = new StarSystem.Planet();
			world.Name = "Mercury";
			world.ID = 0;
			world.Climate = StarSystem.Planet.Climates.Hot;
			world.TypeClass = StarSystem.Planet.TypeClasses.Selena;
			world.OrbitalRadius = AUDistance.ToKilometers(0.4);
			world.Mass = 0.055;
			world.Radius = 2439.7;
			world.SyncAngle = rand.NextDouble() * Math.PI * 2;
			system.Planets.Add(world);

			world = new StarSystem.Planet();
			world.Name = "Venus";
			world.ID = 1;
			world.Climate = StarSystem.Planet.Climates.Hot;
			world.TypeClass = StarSystem.Planet.TypeClasses.Terestrial;
			world.OrbitalRadius = AUDistance.ToKilometers(-0.7);
			world.Mass = 0.815;
			world.Radius =-6051.8;
			world.SyncAngle = rand.NextDouble() * Math.PI * 2;
			system.Planets.Add(world);

			world = new StarSystem.Planet();
			world.Name = "Terra";
			world.ID = 2;
			world.Climate = StarSystem.Planet.Climates.Temperate;
			world.TypeClass = StarSystem.Planet.TypeClasses.Terestrial;
			world.OrbitalRadius = AUDistance.ToKilometers(1);
			world.Mass = 1;
			world.Radius = 6371.0;
			world.SyncAngle = rand.NextDouble() * Math.PI * 2;

			StarSystem.Planet moon = new StarSystem.Planet();
			moon.Name = "Luna";
			moon.Mass = 0.012300;
			moon.OrbitalRadius = 382600;
			//moon.Radius = 

			world.Satalites.Add(moon);
			system.Planets.Add(world);
		}
    }
}
