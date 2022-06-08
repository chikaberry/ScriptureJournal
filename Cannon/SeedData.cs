using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyScriptureJournal.Data;

using System.Linq;

namespace MyScriptureJournal.Cannon
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyScriptureJournalContext>>()))
            {
                // Look for any movies.
                if (context.Scripture.Any())
                {
                    return;   // DB has been seeded
                }
                context.Scripture.AddRange(

                    new Scripture
                    {
                        Book = "Revelations",
                        DateAdded = DateTime.Parse("1989-2-12"),
                        Chapter = 20,
                        Verse = 13,
                        Notes = "Spirit was uplifted and my heart was touched"
                    },


                    new Scripture
                    {
                        Book = "Proverbs",
                        DateAdded = DateTime.Parse("2002-2-12"),
                        Chapter = 10,
                        Verse = 19,
                        Notes = "Brought back memories, thank you Holy Spirit"
                    },


                    new Scripture
                    {
                        Book = "Luke",
                        DateAdded = DateTime.Parse("2008-4-12"),
                        Chapter = 1,
                        Verse = 2,
                        Notes = "Brought back memories, thank you Holy Spirit"
                    },

                    new Scripture
                    {
                        Book = "Alma",
                        DateAdded = DateTime.Parse("2005-8-11"),
                        Chapter = 4,
                        Verse = 3,
                        Notes = "Expounded my understanding"
                    }

                    );
                context.SaveChanges();


            }
        }
    }


} 