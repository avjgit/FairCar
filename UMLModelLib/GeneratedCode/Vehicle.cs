﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Vehicle : Party
{
	public virtual string PlateNumber
	{
		get;
		set;
	}

	public virtual int EngineVolume
	{
		get;
		set;
	}

	public virtual VehicleModels VehicleModel
	{
		get;
		set;
	}

	public virtual IEnumerable<Ownership> Ownership
	{
		get;
		set;
	}

	public virtual IEnumerable<Advertisement> Advertisement
	{
		get;
		set;
	}

	public virtual IEnumerable<ServiceCase> ServiceCase
	{
		get;
		set;
	}

	public virtual IEnumerable<InsuranceCase> InsuranceCase
	{
		get;
		set;
	}

	public virtual IEnumerable<Inspection> Inspection
	{
		get;
		set;
	}

	public virtual void setNewOwner(Buyer newOwner)
	{
		throw new System.NotImplementedException();
	}

	public virtual RepairCause getRepairHistory()
	{
		throw new System.NotImplementedException();
	}

}

