﻿// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.NamingRules", "SA1305:Field names must not use Hungarian notation", Justification = "The concern of this class is generates SQL, and in this case the suffix 'pk' is useful, because represents the primary key from the table.", Scope = "member", Target = "~M:Krafted.Infrastructure.Repositories.Dapper.EntityExtension.ToParams(SharedKernel.Domain.Entity,System.String)~Dapper.DynamicParameters")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.NamingRules", "SA1305:Field names must not use Hungarian notation", Justification = "The concern of this class is generates SQL, and in this case the suffix 'pk' is useful, because represents the primary key from the table.", Scope = "member", Target = "~M:Krafted.Infrastructure.Repositories.Dapper.EntityExtension.ToParam(SharedKernel.Domain.Entity,System.String)~Dapper.DynamicParameters")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1649:File name must match first type name", Justification = "This is a common way to name files that correspond to a generic type. The number after ` correspond to the quantity of generic arguments.", Scope = "type", Target = "~T:Krafted.Infrastructure.Repositories.Dapper.Repository`1")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.NamingRules", "SA1305:Field names must not use Hungarian notation", Justification = "The concern of this class is generates SQL, and in this case the suffix 'pk' is useful, because represents the primary key from the table.", Scope = "member", Target = "~M:Krafted.Infrastructure.Repositories.Dapper.EntityExtension.GetColumnNames(SharedKernel.Domain.Entity,System.String)~System.Collections.Generic.IList{System.String}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "RCS1016:Use expression-bodied member.", Justification = "There will be more instructions in this method", Scope = "member", Target = "~M:Krafted.Infrastructure.Maps.FluentMapConfigurationExtension.AddMap``1(Dapper.FluentMap.Configuration.FluentMapConfiguration)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1821:Remove empty Finalizers", Justification = "Rules on conflict", Scope = "member", Target = "~M:Krafted.Infrastructure.Transactions.UnitOfWork.Finalize")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "CC0037:Remove commented code.", Justification = "The intent here is to reference the author")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1649:File name must match first type name", Justification = "This is a common way to name files that correspond to a generic type. The number after ` correspond to the quantity of generic arguments.", Scope = "type", Target = "~T:Krafted.Infrastructure.Repositories.Dapper.RepositoryAsync`1")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1649:File name must match first type name", Justification = "This is a common way to name files that correspond to a generic type. The number after ` correspond to the quantity of generic arguments.", Scope = "type", Target = "~T:Krafted.Infrastructure.SqlBuilder.SqlBuilderFactory`1")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1649:File name must match first type name", Justification = "This is a common way to name files that correspond to a generic type. The number after ` correspond to the quantity of generic arguments.", Scope = "type", Target = "~T:Krafted.Infrastructure.Sql.SqlBuilderFactory`1")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1127:Generic type constraints must be on their own line", Justification = "Not applicable to expression bodied methods.", Scope = "member", Target = "~M:Krafted.Infrastructure.Sql.SqlBuilderFactory2.NewSqlBuilder``1(System.Data.IDbConnection)~Krafted.Infrastructure.Sql.ISqlBuilder")]