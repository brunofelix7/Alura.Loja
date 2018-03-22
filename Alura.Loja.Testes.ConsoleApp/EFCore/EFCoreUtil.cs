using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Alura.Loja.Testes.ConsoleApp.EFCore {

    public class EFCoreUtil {

        /* Retorna o status e dados das entidades. Rastreia todas as mudancas que estao acontecendo naquela instancia do contexto */
        public static void ShowEntityState(LojaContext context) {
            IEnumerable<EntityEntry> entities = context.ChangeTracker.Entries();
            foreach (EntityEntry item in entities) {
                //  Unchanged(SELECT) | Modified(UPDATE) | Added(INSERT) | Deleted(DELETE) | Detached(NAO MONITORADO)
                Debug.WriteLine($"Entity/Status: {item.Entity.ToString()} - {item.State}");
            }
        }

        /* Retorna o SQL gerado pelo EFCore */
        public static void ShowSQL(LojaContext context) {
            var serviceProvider = context.GetInfrastructure<IServiceProvider>();
            var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
            loggerFactory.AddProvider(SqlLoggerProvider.Create());
        }
    }
}
