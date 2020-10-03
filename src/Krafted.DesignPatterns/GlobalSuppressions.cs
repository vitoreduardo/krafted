// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1649:File name must match first type name", Justification = "This is a common way to name files that correspond to a generic type. The number after ` correspond to the quantity of generic arguments.", Scope = "NamespaceAndDescendants", Target = "Krafted.DesignPatterns.Factories")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "CA1716: Rename virtual/interface member", Justification = "NewSomething is the name commonly used for the creation method in FactoryMethod. In this case FactoryMethod is generic and New can be any type .So in this context, New is a good name", Scope = "NamespaceAndDescendants", Target = "Krafted.DesignPatterns.Factories")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:Elements should be documented", Justification = "Internal type that doesn't expose public API", Scope = "type", Target = "~T:Krafted.DesignPatterns.Specifications.OrSpecification`1")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:Elements should be documented", Justification = "Internal type that doesn't expose public API", Scope = "type", Target = "~T:Krafted.DesignPatterns.Specifications.NotSpecification`1")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:Elements should be documented", Justification = "Internal type that doesn't expose public API", Scope = "type", Target = "~T:Krafted.DesignPatterns.Specifications.IdentitySpecification`1")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:Elements should be documented", Justification = "Internal type that doesn't expose public API", Scope = "type", Target = "~T:Krafted.DesignPatterns.Specifications.AndSpecification`1")]
[assembly: SuppressMessage("Redundancy", "RCS1163:Unused parameter.", Justification = "Not applicable", Scope = "member", Target = "~M:Krafted.DesignPatterns.Specifications.IdentitySpecification`1.ToExpression~System.Linq.Expressions.Expression{System.Func{`0,System.Boolean}}")]
[assembly: SuppressMessage("Style", "CC0001:You should use 'var' whenever possible.", Justification = "In this case the explicit type improves readability", Scope = "member", Target = "~M:Krafted.DesignPatterns.Specifications.OrSpecification`1.ToExpression~System.Linq.Expressions.Expression{System.Func{`0,System.Boolean}}")]
[assembly: SuppressMessage("Style", "CC0001:You should use 'var' whenever possible.", Justification = "In this case the explicit type improves readability", Scope = "member", Target = "~M:Krafted.DesignPatterns.Specifications.NotSpecification`1.ToExpression~System.Linq.Expressions.Expression{System.Func{`0,System.Boolean}}")]
[assembly: SuppressMessage("Style", "CC0001:You should use 'var' whenever possible.", Justification = "In this case the explicit type improves readability", Scope = "member", Target = "~M:Krafted.DesignPatterns.Specifications.AndSpecification`1.ToExpression~System.Linq.Expressions.Expression{System.Func{`0,System.Boolean}}")]
[assembly: SuppressMessage("Style", "CC0001:You should use 'var' whenever possible.", Justification = "In this case the explicit type improves readability", Scope = "member", Target = "~M:Krafted.DesignPatterns.Specifications.Specification`1.IsSatisfiedBy(`0)~System.Boolean")]
[assembly: SuppressMessage("Style", "CC0037:Remove commented code.", Justification = "This comment is a header documentation")]
[assembly: SuppressMessage("Design", "CA1005:Avoid excessive parameters on generic types", Justification = "Not Applicable", Scope = "type", Target = "~T:Krafted.DesignPatterns.Factories.IAbstractFactory`3")]
[assembly: SuppressMessage("Design", "CA1005:Avoid excessive parameters on generic types", Justification = "Not Applicable", Scope = "type", Target = "~T:Krafted.DesignPatterns.Factories.IAbstractFactory`4")]
[assembly: SuppressMessage("Design", "CA1005:Avoid excessive parameters on generic types", Justification = "Not Applicable", Scope = "type", Target = "~T:Krafted.DesignPatterns.Factories.IAbstractFactory`5")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "GuardAgainst", Scope = "member", Target = "~M:Krafted.DesignPatterns.Notifications.Notifiable.Validate``1(``0,FluentValidation.AbstractValidator{``0})~System.Boolean")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:Elements should be documented", Justification = "inheritdoc", Scope = "member", Target = "~M:Krafted.DesignPatterns.Notifications.NotificationContext.#ctor")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:Elements should be documented", Justification = "inheritdoc", Scope = "member", Target = "~P:Krafted.DesignPatterns.Notifications.NotificationContext.HasNotifications")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:Elements should be documented", Justification = "inheritdoc", Scope = "member", Target = "~P:Krafted.DesignPatterns.Notifications.NotificationContext.Notifications")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:Elements should be documented", Justification = "inheritdoc", Scope = "member", Target = "~M:Krafted.DesignPatterns.Notifications.NotificationContext.AddNotification(Krafted.DesignPatterns.Notifications.Notification)")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:Elements should be documented", Justification = "inheritdoc", Scope = "member", Target = "~M:Krafted.DesignPatterns.Notifications.NotificationContext.AddNotifications(System.Collections.Generic.IEnumerable{Krafted.DesignPatterns.Notifications.Notification})")]
[assembly: SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1201:Elements should appear in the correct order", Justification = "Improves readability by being close to the backfield", Scope = "member", Target = "~F:Krafted.DesignPatterns.Notifications.Notifiable._notifications")]
[assembly: SuppressMessage("Naming", "CA1711:Identifiers should not have incorrect suffix", Justification = "Not Applicable", Scope = "type", Target = "~T:Krafted.DesignPatterns.Ddd.IDomainNotificationCollection")]
[assembly: SuppressMessage("Naming", "CA1711:Identifiers should not have incorrect suffix", Justification = "Not Applicable", Scope = "type", Target = "~T:Krafted.DesignPatterns.Ddd.IDomainEventCollection")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "Guard.Against", Scope = "member", Target = "~M:Krafted.DesignPatterns.Ddd.EntityExtension.PublishEvent(System.Collections.Concurrent.ConcurrentQueue{Krafted.DesignPatterns.Ddd.IDomainEvent},Krafted.DesignPatterns.Ddd.IDomainEvent)")]
