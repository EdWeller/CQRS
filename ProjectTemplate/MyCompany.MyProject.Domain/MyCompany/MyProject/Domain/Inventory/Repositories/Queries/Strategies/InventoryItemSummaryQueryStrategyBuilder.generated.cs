﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#region Copyright
// -----------------------------------------------------------------------
// <copyright company="cdmdotnet Limited">
//     Copyright cdmdotnet Limited. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
#endregion
using Cqrs.Domain;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Cqrs.Configuration;
using Cqrs.Authentication;
using Cqrs.Repositories.Queries;
using MyCompany.MyProject.Domain.Factories;

namespace MyCompany.MyProject.Domain.Inventory.Repositories.Queries.Strategies
{
	[GeneratedCode("CQRS UML Code Generator", "1.500.523.412")]
	public partial class InventoryItemSummaryQueryStrategyBuilder : QueryBuilder<InventoryItemSummaryQueryStrategy, Entities.InventoryItemSummaryEntity>, IInventoryItemSummaryQueryStrategyBuilder
	{
		public InventoryItemSummaryQueryStrategyBuilder(IDomainDataStoreFactory dataStoreFactory, IDependencyResolver dependencyResolver)
			: base(dataStoreFactory.GetInventoryItemSummaryDataStore(), dependencyResolver)
		{
		}

		#region Overrides of QueryBuilder<InventoryItemSummaryQueryStrategy,Entities.InventoryItemSummaryEntity>

		protected override IQueryable<Entities.InventoryItemSummaryEntity> GeneratePredicate(QueryPredicate queryPredicate, IQueryable<Entities.InventoryItemSummaryEntity> leftHandQueryable = null)
		{
			InventoryItemSummaryQueryStrategy queryStrategy = GetNullQueryStrategy();
			SortedSet<QueryParameter> parameters = queryPredicate.Parameters;

			IQueryable<Entities.InventoryItemSummaryEntity> resultingQueryable = null;
			if (queryPredicate.Name == GetFunctionName<Guid>(queryStrategy.WithRsn))
			{
				OnGeneratePredicateWithRsn(queryPredicate, leftHandQueryable, parameters, ref resultingQueryable);
				GeneratePredicateWithRsn(parameters, leftHandQueryable, ref resultingQueryable);
				OnGeneratedPredicateWithRsn(queryPredicate, leftHandQueryable, parameters, ref resultingQueryable);
				return resultingQueryable;
			}

			resultingQueryable
				= GeneratePredicateWithPermissionScopeAny<ISingleSignOnToken>(queryPredicate, leftHandQueryable)
				?? GeneratePredicateWithPermissionScopeUser<ISingleSignOnToken>(queryPredicate, leftHandQueryable)
				?? GeneratePredicateWithPermissionScopeCompany<ISingleSignOnToken>(queryPredicate, leftHandQueryable)
				?? GeneratePredicateWithPermissionScopeCompanyAndUser<ISingleSignOnToken>(queryPredicate, leftHandQueryable);

			if (resultingQueryable != null)
				return resultingQueryable;

			throw new InvalidOperationException("No known predicate could be generated.");
		}

		#endregion

		partial void OnGeneratePredicateWithRsn(QueryPredicate queryPredicate, IQueryable<Entities.InventoryItemSummaryEntity> leftHandQueryable, SortedSet<QueryParameter> parameters, ref IQueryable<Entities.InventoryItemSummaryEntity> resultingQueryable);

		partial void GeneratePredicateWithRsn(SortedSet<QueryParameter> parameters, IQueryable<Entities.InventoryItemSummaryEntity> leftHandQueryable, ref IQueryable<Entities.InventoryItemSummaryEntity> resultingQueryable);

		partial void OnGeneratedPredicateWithRsn(QueryPredicate queryPredicate, IQueryable<Entities.InventoryItemSummaryEntity> leftHandQueryable, SortedSet<QueryParameter> parameters, ref IQueryable<Entities.InventoryItemSummaryEntity> resultingQueryable);


		protected override void ApplySorting(InventoryItemSummaryQueryStrategy queryStrategy, ref IQueryable<Entities.InventoryItemSummaryEntity> queryable)
		{
			var orderQueryable = (IOrderedQueryable<Entities.InventoryItemSummaryEntity>)queryable;

			int index = 0;
			foreach (Func<int, InventoryItemSummaryQueryStrategy> sortingMethod in queryStrategy.SortingList)
			{

			}
			queryable = orderQueryable;
		}

	}
}
