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

public abstract class Person : Party
{
	public virtual string FullName
	{
		get;
		set;
	}

	public virtual IEnumerable<Ownership> Ownership
	{
		get;
		set;
	}

	public virtual IEnumerable<Offer> Offer
	{
		get;
		set;
	}

	public virtual Contact Contact
	{
		get;
		set;
	}

	public virtual void SendOffer(Offer offer)
	{
		throw new System.NotImplementedException();
	}

	public virtual void AcceptOffer(Offer offer)
	{
		throw new System.NotImplementedException();
	}

	public virtual IEnumerable<Vehicle> Vehicles()
	{
		throw new System.NotImplementedException();
	}

	public virtual void PublishAdvertisement(Advertisement advertisement)
	{
		throw new System.NotImplementedException();
	}

}
