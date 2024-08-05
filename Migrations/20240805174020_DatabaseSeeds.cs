using System;
using LibraryApp.Models;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryApp.Migrations
{
    public partial class DatabaseSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { nameof(Book.Title), nameof(Book.Synopsis), nameof(Book.Status), nameof(Book.CreatedAt), nameof(Book.UpdatedAt)},
                values: new object[,]
                {
                    { "Old Man and the Sea", " The last novel Ernest Hemingway saw published, The Old Man and the Sea has proved itself to be one of the enduring works of American fiction. It is the story of an old Cuban fisherman and his supreme ordeal: a relentless, agonizing battle with a giant marlin far out in the Gulf Stream. Using the simple, powerful language of a fable, Hemingway takes the timeless themes of courage in the face of defeat and personal triumph won from loss and transforms them into a magnificent twentieth-century classic. ", 1, DateTime.Now, DateTime.Now },
                    { "A Raisin in the Sun", "Lorraine Hansberry's award-winning play about the hopes and aspirations of a struggling, working-class family on Chicago's South Side resonated deeply with black America's psyche—and forever reshaped American theatre. The title of the play is derived from a phrase in Langston Hughes' poem \"Harlem,\" which warns that if a dream is postponed, it will \"dry up/like a raisin in the sun.\"\n\"The events of every passing year add resonance to A Raisin in the Sun,\" said The New York Times. \"It is as if history is conspiring to make the play a classic.\"", 1, DateTime.Now, DateTime.Now },
                    { "The Scarlet Letter", "The Scarlet Letter: A Romance is a work of historical fiction by American author Nathaniel Hawthorne, published in 1850. Set in the Puritan Massachusetts Bay Colony during the years 1642 to 1649, the novel tells the story of Hester Prynne, who conceives a daughter with a man to whom she is not married and then struggles to create a new life of repentance and dignity. Containing a number of religious and historic allusions, the book explores themes of legalism, sin, and guilt.\n\nThe Scarlet Letter was one of the first mass-produced books in the United States. It was popular when first published and is considered a classic work of American literature. The novel has inspired numerous film, television, and stage adaptations. Critics have described The Scarlet Letter as a masterwork, and novelist D. H. Lawrence called it a \"perfect work of the American imagination\".", 1, DateTime.Now, DateTime.Now },
                    { "The Promise of Tomorrow", "\n\nFrom the author of The Brighter the Light comes the moving story about one woman’s reason for leaving home and the love that brings her back.\n\nWhen Olympia leaves her small Virginia town, she doesn’t expect to look back, much less ever come home. But after a year on the road, her sister’s engagement pulls Olympia into everything she left behind: her family, her husband, and the grief she’s been trying to forget.\n\nShe’s determined to stay a few days, maybe a week—just enough time to visit gravestones and sign off on the divorce her husband, Spencer, asked for. But he’s reeling from their shared loss, as well as complications with his aging parents, leaving his heart just as fragile as Olympia’s. The more time they spend in each other’s orbit, the less sure they are they’ll be able to walk away for good.\n\nAs family secrets come to light and family bonds stretch to the breaking point, Olympia must decide where she’s going next and where she belongs. She’s used to coping with life’s complications alone, but maybe the best way to heal is together.\n", 1, DateTime.Now, DateTime.Now },
                    { "The Lioness of Morocco", "ndependent-minded Sibylla Spencer feels trapped in nineteenth-century London, where her strong will and progressive views have rendered her unmarriageable. Still single at twenty-three, she is treated like a child and feels stifled in her controlling father's house.\n\nWhen Benjamin Hopkins, an ambitious employee of her father's trading company, shows an interest in her, she realizes marriage is her only chance to escape. As Benjamin's rising career whisks them both away to exotic Morocco, Sibylla is at last a citizen of the world, reveling in her newfound freedom by striking her first business deals, befriending locals…and falling in love for the first time with a charismatic and handsome Frenchman.\n\nBut Benjamin's lust for money and influence draws him into dark dealings, pulling him ever further from Sibylla and their two young sons. When he's arrested on horrible charges, the fate of Sibylla's family rests on her shoulders, as she must decide whether she'll leave him to his fate or help him fight for his life.", 1, DateTime.Now, DateTime.Now },
                    // { "", "", 1, DateTime.Now, DateTime.Now },
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
