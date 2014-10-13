﻿using System;
using System.Collections.Generic;
using System.Linq;
using Cqrs.Events;
using Cqrs.Authentication;

namespace Cqrs.Tests.Substitutes
{
	public class TestEventStore : IEventStore<ISingleSignOnToken>
	{
		public TestEventStore()
		{
			EmptyGuid = Guid.NewGuid();
			SavedEvents = new List<IEvent<ISingleSignOnToken>>();
		}

		public Guid EmptyGuid { get; private set; }

		public void Save(IEvent<ISingleSignOnToken> @event, Type aggregateRootType)
		{
			SavedEvents.Add(@event);
		}

		public IEnumerable<IEvent<ISingleSignOnToken>> Get<T>(Guid aggregateId, bool useLastEventOnly = false, int fromVersion = -1)
		{
			if (aggregateId == EmptyGuid || aggregateId == Guid.Empty)
			{
				return new List<IEvent<ISingleSignOnToken>>();
			}

			return new List<IEvent<ISingleSignOnToken>>
				{
					new TestAggregateDidSomething {Id = aggregateId, Version = 1},
					new TestAggregateDidSomeethingElse {Id = aggregateId, Version = 2},
					new TestAggregateDidSomething {Id = aggregateId, Version = 3},
				}.Where(x => x.Version > fromVersion);

		}

		public void Save<T>(IEvent<ISingleSignOnToken> @event)
		{
			SavedEvents.Add(@event);
		}

		private List<IEvent<ISingleSignOnToken>> SavedEvents { get; set; }
	}
}