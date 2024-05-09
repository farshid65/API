<<<<<<< HEAD
﻿using Microsoft.EntityFrameworkCore;

namespace Models;

public class DatabaseContext : DbContext
{
	public DatabaseContext() : base()
	{
	}

	#region General

	#region //E
	#endregion //E

	#region //M
	#endregion //M

	#region //P
	#endregion //P

	#region //R
	#endregion //R

	#region //S
	#endregion //S

	#region //U
	#endregion //U

	#endregion /General

	#region /Core

	#region //B
	#endregion //B

	#region //C
	//public virtual DbSet<Country> Countries { get; set; }
	#endregion //C

	#region //D
	#endregion //D

	#region //F
	#endregion //F

	#region //I
	#endregion //I

	#region //K
	#endregion //K

	#region //N
	#endregion //N

	#region //P
	#endregion //P

	#region //S
	#endregion //S

	#region //T
	#endregion //T

	#region //W
	#endregion //W

	#endregion /Core

	protected override void OnConfiguring
		(DbContextOptionsBuilder optionsBuilder)
	{
		var connectionString =
		"Server=.,1433;User ID=username;Password=password;Database=PharmacyDB;MultipleActiveResultSets=true;TrustServerCertificate=True;";

		optionsBuilder.UseSqlServer
			(connectionString: connectionString);
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		#region Relations

		//#region Country-City 1-*
		//modelBuilder.Entity<Country>()
		//		.HasMany(parent => parent.Cities)
		//		.WithOne(child => child.City)
		//		.HasForeignKey(child => child.CityId);
		//#endregion Country-City 1-*

		#endregion /Relations

		base.OnModelCreating(modelBuilder);

	}
}
=======
﻿using Microsoft.EntityFrameworkCore;
using Models.Infrastructure;

namespace Models;

public class DatabaseContext : DbContext
{
	public DatabaseContext(/*DbContextOptions<DatabaseContext>options*/) : base(/*options*/)
	{
	}

	#region General

	#region //E
	#endregion //E

	#region //M
	#endregion //M

	#region //P
	#endregion //P

	#region //R
	#endregion //R

	#region //S
	#endregion //S

	#region //U
	#endregion //U

	#endregion /General

	#region /Core

	#region //B
	#endregion //B

	#region //C
	//public virtual DbSet<Country> Countries { get; set; }
	#endregion //C

	#region //D
	#endregion //D

	#region //F
	#endregion //F

	#region //I
	#endregion //I

	#region //K
	#endregion //K

	#region //N
	#endregion //N

	#region //P
	#endregion //P

	#region //S
	#endregion //S

	#region //T
	#endregion //T

	#region //W
	#endregion //W

	#endregion /Core

	protected override void OnConfiguring
		(DbContextOptionsBuilder optionsBuilder)
	{
		var connectionString =
        "Server=.;User ID=WorldCities;Password=MyVeryOwn$721;Database=PharmacyDB;Integrated Security=False;MultipleActiveResultSets=true;TrustServerCertificate=True;";

		optionsBuilder.UseSqlServer
			(connectionString: connectionString);
	}
    public DbSet<Country> Countries { get; set; }
    public DbSet<City> Cities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		#region Relations

		#region Country-City 1-*
		modelBuilder.Entity<Country>()			
				.HasMany(parent => parent.Cities)
				.WithOne(child => child.Country)
				.HasForeignKey(child => child.CountryId);
		#endregion Country-City 1-*


		#endregion /Relations

		base.OnModelCreating(modelBuilder);

	}
}
>>>>>>> 3618dd1 (first commit)
