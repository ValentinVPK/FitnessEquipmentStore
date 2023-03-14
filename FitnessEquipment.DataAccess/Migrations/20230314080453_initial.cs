using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitnessEquipment.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WeightTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeightTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeightItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeightTypeId = table.Column<int>(type: "int", nullable: false),
                    Kgs = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    Materials = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeightItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeightItems_WeightTypes_WeightTypeId",
                        column: x => x.WeightTypeId,
                        principalTable: "WeightTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "WeightTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Dumbbells are a highly effective tool for building strength and muscle mass due to their versatility and ability to target specific muscle groups. They offer a greater range of motion than other weight training equipment, allowing for more muscle fibers to be engaged during exercises. Additionally, their adjustable weight feature allows for easy progression as strength increases, making them a great choice for both beginners and experienced lifters.", "Dumbells" },
                    { 2, "Kettlebells are an effective tool for building strength, endurance, and flexibility due to their unique shape and design. They allow for a wide range of dynamic movements that engage multiple muscle groups simultaneously, improving overall fitness and coordination. Kettlebells are also highly versatile and can be used for a variety of exercises, including swings, snatches, and Turkish get-ups, making them an excellent choice for anyone looking to challenge their body and take their workouts to the next level.", "Kettlebells" },
                    { 3, "Weight plates are circular metal discs that are used to add resistance to a barbell, dumbbell, or weight machine. They come in a variety of sizes and weights, allowing users to gradually increase resistance levels as their strength improves, making them a versatile and essential tool in strength training and fitness programs.", "Plates" },
                    { 4, "Training with barbells is highly effective for building strength and muscle mass due to their ability to provide heavy resistance and target multiple muscle groups simultaneously. Barbells allow for a variety of compound exercises, such as squats, deadlifts, and bench press, which engage a large number of muscle fibers and promote overall growth and development. Additionally, their ability to progressively overload allows for continued gains in strength and muscle size, making them a staple in many strength training programs.", "Barbells" }
                });

            migrationBuilder.InsertData(
                table: "WeightItems",
                columns: new[] { "Id", "Description", "ImagePath", "Kgs", "Materials", "Name", "Price", "WeightTypeId" },
                values: new object[,]
                {
                    { 1, "Dumbbells are a type of weight training equipment that consists of a short bar with weights attached to both ends. They are commonly used for strength training exercises that target specific muscle groups in the arms, chest, shoulders, and back.", null, 32.5m, "SteelAndRubber", "Dumbells Hex Pro", 250m, 1 },
                    { 2, "Dumbbells are a type of weight training equipment that consists of a short bar with weights attached to both ends. They are commonly used for strength training exercises that target specific muscle groups in the arms, chest, shoulders, and back.", null, 10m, "SteelAndRubber", "Dumbells TPU Series", 90m, 1 },
                    { 3, "Dumbbells are a type of weight training equipment that consists of a short bar with weights attached to both ends. They are commonly used for strength training exercises that target specific muscle groups in the arms, chest, shoulders, and back.", null, 15m, "CastIron", "Adjustable dumbells", 120m, 1 },
                    { 4, "Kettlebells are weights that resemble a cannonball with a handle. They are used for strength training, cardiovascular fitness, and flexibility exercises, making them a versatile and effective tool for fitness enthusiasts and athletes alike.", null, 40m, "Steel", "Russian Kettlebell", 250m, 2 },
                    { 5, "Kettlebells are weights that resemble a cannonball with a handle. They are used for strength training, cardiovascular fitness, and flexibility exercises, making them a versatile and effective tool for fitness enthusiasts and athletes alike.", null, 16m, "Steel", "HQ Competition Kettlebell", 90m, 2 },
                    { 6, "Kettlebells are weights that resemble a cannonball with a handle. They are used for strength training, cardiovascular fitness, and flexibility exercises, making them a versatile and effective tool for fitness enthusiasts and athletes alike.", null, 8m, "SteelAndRubber", "Vinyl Kettlebell", 40m, 2 },
                    { 7, "Weight plates are circular discs made of various materials such as iron, steel or rubber, used for resistance training and weightlifting exercises. They come in different sizes and weights, and are attached to barbells and weight machines to increase resistance and challenge the muscles during workouts.", null, 10m, "Steel", "ATX Bumper Plates", 200m, 3 },
                    { 8, "Weight plates are circular discs made of various materials such as iron, steel or rubber, used for resistance training and weightlifting exercises. They come in different sizes and weights, and are attached to barbells and weight machines to increase resistance and challenge the muscles during workouts.", null, 20m, "Rubber", "ATX Color Splash Plates", 150m, 3 },
                    { 9, "Weight plates are circular discs made of various materials such as iron, steel or rubber, used for resistance training and weightlifting exercises. They come in different sizes and weights, and are attached to barbells and weight machines to increase resistance and challenge the muscles during workouts.", null, 2m, "Steel", "ATX Fractional Plates", 50m, 3 },
                    { 10, "Barbells are long metal bars with sleeves at either end for holding weight plates, used for strength training and weightlifting exercises. They come in different lengths, weights, and designs, and are a fundamental tool for building strength, power, and muscular endurance.", null, 20m, "CastIron", "ATX – XTP Raw Powerlifting Bar", 700m, 4 },
                    { 11, "Barbells are long metal bars with sleeves at either end for holding weight plates, used for strength training and weightlifting exercises. They come in different lengths, weights, and designs, and are a fundamental tool for building strength, power, and muscular endurance.", null, 25m, "Steel", "ATX Trap Bar XL", 300m, 4 },
                    { 12, "Barbells are long metal bars with sleeves at either end for holding weight plates, used for strength training and weightlifting exercises. They come in different lengths, weights, and designs, and are a fundamental tool for building strength, power, and muscular endurance.", null, 12m, "CastIron", "Curl SZ PRO Bar ATX", 150m, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_WeightItems_WeightTypeId",
                table: "WeightItems",
                column: "WeightTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeightItems");

            migrationBuilder.DropTable(
                name: "WeightTypes");
        }
    }
}
