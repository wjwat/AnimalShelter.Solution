using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Api.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1,
                columns: new[] { "Breed", "Description", "Name", "Species" },
                values: new object[] { "Middle Green", "Timberwolf Permanent Geranium Lake Turquoise Blue Teal Blue Sky Blue Vivid Tangerine Medium Violet Orange Permanent Geranium Lake Blue Bell Tropical Rain Forest Granny Smith Apple Purple Heart Canary Green-Blue Madder Lake Almond Outer Space Copper Shamrock Caribbean Green Orange-Red Madder Lake Maximum Purple Sea Green Mauvelous Cornflower Melon Pacific Blue Salmon Tan Burnt Orange Razzmatazz Copper Permanent Geranium Lake Cadet Blue Middle Red Sunset Orange Razzmatazz Sepia Apricot Mahogany Yellow-Green Outer Space Orchid Raw Umber Banana Mania Middle Blue Turquoise Blue Spring Green", "Maize", "Black" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                columns: new[] { "Breed", "Description", "Name", "Species", "Status" },
                values: new object[] { "Granny Smith Apple", "Caribbean Green Plum Madder Lake Blue Fuzzy Wuzzy Blue-Green Lemon Yellow Antique Brass Yellow-Orange Thistle Gray Teal Blue Cerulean Brown Royal Purple Dandelion Wild Strawberry Yellow-Orange Middle Red Magenta Orange-Red Middle Red Purple Canary Violet-Red Desert Sand Middle Yellow Red Pink Sherbert Melon Cadet Blue Orange-Red Antique Brass Green-Yellow Cadet Blue Light Chrome Green Mulberry Maize Cerulean Blue Burnt Orange Aquamarine Navy Blue Brown Mango Tango Gold Navy Blue Green Jazzberry Jam Light Venetian Red Timberwolf Green Royal Purple", "Bittersweet", "Middle Green Yellow", 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3,
                columns: new[] { "Breed", "Description", "Name", "Species", "Status" },
                values: new object[] { "Fuzzy Wuzzy", "Goldenrod English Vermilion White Middle Blue Green Yellow-Green Pink Flamingo Yellow-Green Mulberry Green-Blue Antique Brass Yellow-Green Wild Blue Yonder Tan Pacific Blue Piggy Pink Dandelion Burnt Sienna Red Middle Purple White Middle Blue Purple Raw Sienna Madder Lake Manatee Melon Vivid Tangerine White Violet-Red Violet Maximum Purple Copper Blush Wild Strawberry Antique Brass Bittersweet Royal Purple Blush Ultramarine Blue Blue Scarlet Yellow-Orange Lavender Magenta Burnt Orange Cerulean Light Blue Yellow Melon Mango Tango Mountain Meadow", "Middle Green Yellow", "Purple Heart", 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4,
                columns: new[] { "Breed", "Description", "Name", "Species", "Status" },
                values: new object[] { "Ultramarine Blue", "Peach Mauvelous Lemon Yellow Sky Blue Violet Light Chrome Green Green Purple Heart Green-Yellow Pine Green Violet-Red Beaver Apricot Yellow Sky Blue Silver Raw Sienna Blue Middle Blue Green Maximum Purple Thistle Middle Red Teal Blue Teal Blue Mahogany Maximum Yellow Red Bittersweet Maximum Blue Purple Melon Scarlet Red-Violet Scarlet Middle Red Shadow Cotton Candy Green-Blue Tan Fuzzy Wuzzy Pink Flamingo Blue-Violet Yellow Granny Smith Apple Robin's Egg Blue Wild Strawberry Forest Green Manatee Asparagus Sepia Middle Green Yellow Macaroni and Cheese", "Outer Space", "Manatee", 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5,
                columns: new[] { "Breed", "Description", "Name", "Species" },
                values: new object[] { "Madder Lake", "Sepia Maximum Red Blue-Green Bluetiful Gold Permanent Geranium Lake Desert Sand Thistle Cobalt Blue Permanent Geranium Lake Granny Smith Apple Red-Orange Granny Smith Apple White Red-Violet Maximum Purple Blue-Green Charcoal Gray Pink Sherbert Cerulean Violet Lavender Sunset Orange Tickle Me Pink Green Tropical Rain Forest Peach Cerise Middle Red Purple Light Chrome Green Medium Rose Lavender Cerise Purple Mountains' Majesty Pine Green Van Dyke Brown Silver Shamrock Fern Royal Purple Canary Gray Light Blue Timberwolf Magenta Blush Orange-Yellow Royal Purple Lavender Mahogany", "Blush", "Royal Purple" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Breed", "Description", "Name", "Species", "Status" },
                values: new object[,]
                {
                    { 49, "Fuzzy Wuzzy", "Medium Chrome Green Medium Chrome Green Shadow Orange-Yellow Midnight Blue Fuzzy Wuzzy Maroon Madder Lake Fuzzy Wuzzy Gold Piggy Pink Sepia Magenta Orange-Red Copper Pine Green Robin's Egg Blue Tumbleweed Ultramarine Blue Maximum Purple Bluetiful Medium Violet Vivid Violet Lemon Yellow Raw Sienna Goldenrod Melon Teal Blue Green-Blue Desert Sand Cadet Blue Middle Blue Purple Dandelion Silver Pacific Blue Maximum Green Sunset Orange Middle Blue Green Celestial Blue Brown Almond Silver Lemon Yellow Outer Space Indian Red Manatee Piggy Pink Forest Green Mango Tango Gray", "Mahogany", "Pine Green", 1 },
                    { 32, "Blue-Gray", "Bittersweet Cobalt Blue Pacific Blue Maximum Blue Green Spring Green Inchworm Pacific Blue Light Venetian Red Timberwolf Fuzzy Wuzzy Ultramarine Blue Cadet Blue Sky Blue Fuchsia Van Dyke Brown Middle Blue Purple Canary Brilliant Rose Denim Maximum Yellow Red Shadow Maroon Middle Yellow Red Gray Maximum Green Yellow Banana Mania Periwinkle Dandelion Salmon Lavender Yellow-Orange Maximum Blue Purple Apricot Dandelion Middle Blue Purple Salmon Peach Van Dyke Brown Indian Red Mauvelous Middle Yellow Middle Green Pine Green Outer Space Maximum Red Blue Bell Navy Blue Periwinkle Cerise", "Red-Violet", "Middle Green", 0 },
                    { 33, "Cornflower", "Purple Mountains' Majesty Blue-Green Outer Space Almond Yellow-Green Spring Green Maximum Blue Green-Blue Middle Yellow Cerise Yellow-Green Blush Tumbleweed Pink Flamingo White Maximum Yellow Purple Mountains' Majesty Magenta Dandelion Macaroni and Cheese Carnation Pink Shamrock Royal Purple Cerulean Blue Pink Sherbert Burnt Sienna Maximum Purple Violet-Blue Red-Violet Celestial Blue Cadet Blue Carnation Pink Eggplant Maximum Green Indigo Maximum Blue Green Pink Flamingo Shadow Cerulean Blue Denim Cerulean Turquoise Blue Pink Sherbert Maximum Green Yellow Black Charcoal Gray Yellow Beaver Mulberry Lavender", "Fern", "Middle Blue Green", 0 },
                    { 34, "Middle Blue", "Pink Sherbert Tickle Me Pink Orchid Teal Blue Maximum Blue Green Charcoal Gray Middle Blue Middle Red Purple Maximum Blue Purple Sea Green Canary Cobalt Blue Orange Cadet Blue Antique Brass Lemon Yellow Aquamarine Fuzzy Wuzzy Lemon Yellow Purple Heart Almond Melon Orange Medium Rose White Vivid Tangerine Granny Smith Apple Cotton Candy Sunset Orange Blue-Green Desert Sand Blue Beaver Purple Mountains' Majesty Turquoise Blue Mauvelous Purple Mountains' Majesty Orange-Red Cerulean Maximum Red Indian Red Violet-Red Middle Blue Maximum Red Cadet Blue Middle Blue Green Burnt Sienna Cotton Candy Maximum Yellow Brilliant Rose", "Cerulean Blue", "Fuchsia", 1 },
                    { 35, "Tan", "Indian Red Copper Burnt Sienna Maximum Yellow Melon Brilliant Rose Lavender Vivid Tangerine Blue Bell Tumbleweed Light Chrome Green Green-Blue Raw Sienna Brick Red Maximum Purple Middle Purple Medium Chrome Green Medium Violet Royal Purple Burnt Orange Orange-Red Cornflower Salmon Shadow Middle Red Cerulean Blue Goldenrod Charcoal Gray Violet Midnight Blue English Vermilion Yellow-Orange Mahogany Cotton Candy Macaroni and Cheese Fuzzy Wuzzy Aquamarine Middle Red Middle Red Bittersweet Maximum Yellow Blue-Violet Midnight Blue Indigo Middle Blue Mahogany Burnt Sienna Cerulean Tropical Rain Forest Cobalt Blue", "White", "Middle Yellow", 0 },
                    { 36, "Turquoise Blue", "Piggy Pink Purple Heart Orange Maximum Green Maximum Green Yellow Jungle Green Inchworm Orange-Red Orange-Red Blue-Violet Charcoal Gray Maize Violet-Red Blue-Gray Gray Apricot Maximum Red Purple Orange-Red Red Maximum Red Robin's Egg Blue Light Blue Antique Brass Blue-Gray Caribbean Green Almond Blue-Violet Asparagus Maximum Blue Purple Cobalt Blue Scarlet Middle Green Yellow Tickle Me Pink Shadow Cotton Candy Gold Mango Tango Violet-Blue Spring Green Maximum Blue Green Orange Outer Space English Vermilion Jungle Green Middle Blue Green Maximum Blue Purple Cerise Green-Yellow Sunset Orange Maximum Blue", "Tumbleweed", "Scarlet", 0 },
                    { 37, "Maximum Yellow", "Maximum Red Middle Red Violet Aquamarine Maximum Purple Red-Violet Melon Vivid Tangerine Sea Green Middle Yellow Red Venetian Red Maximum Red Purple Piggy Pink Razzmatazz Maximum Green Light Blue Celestial Blue Spring Green Black Outer Space Green-Yellow Turquoise Blue Yellow-Orange Middle Blue Purple Maximum Blue Purple Almond Celestial Blue Bittersweet Maximum Purple Madder Lake Fuchsia Middle Red Purple Peach Timberwolf Bluetiful Sepia Maximum Blue Wisteria Red Red Green-Yellow Pacific Blue Raw Umber Mahogany Burnt Sienna Cobalt Blue Salmon Denim Gray Maroon", "Medium Violet", "Green", 0 },
                    { 38, "Middle Red Purple", "Almond Green-Yellow Charcoal Gray Ultramarine Blue Antique Brass Orange Robin's Egg Blue Middle Green Middle Blue Purple Ultramarine Blue Spring Green Peach Apricot Orange Cerise Shadow English Vermilion Salmon Middle Blue Green Shamrock Manatee Beaver Orange-Yellow Caribbean Green Sunset Orange Sky Blue Timberwolf Mahogany Brown Almond Indigo Maximum Green Yellow Vivid Tangerine Middle Red Purple Macaroni and Cheese Violet-Blue Jazzberry Jam Gold Tan Blue-Green Purple Heart Light Chrome Green Brown Timberwolf Teal Blue Tumbleweed Mauvelous Purple Heart Canary Indigo", "Cadet Blue", "Wild Strawberry", 1 },
                    { 39, "Medium Violet", "Purple Mountains' Majesty Royal Purple Mulberry Wild Strawberry Wild Blue Yonder Gold Timberwolf Tan Orange-Red Tumbleweed Piggy Pink Tan Red-Violet Medium Chrome Green Middle Green Wisteria Brick Red Fuzzy Wuzzy Jazzberry Jam Jazzberry Jam Violet-Blue Blue Raw Sienna Royal Purple Robin's Egg Blue Orange-Red Blue-Violet Outer Space Tan Salmon Manatee Carnation Pink Light Venetian Red Jazzberry Jam Periwinkle Melon Maximum Yellow Tickle Me Pink Wild Blue Yonder Antique Brass Green-Yellow Fern Dark Venetian Red Robin's Egg Blue Van Dyke Brown Wisteria Raw Umber Middle Red Tumbleweed Yellow-Orange", "Cerulean", "Middle Red", 1 },
                    { 40, "Maximum Green", "Cerulean Indian Red Celestial Blue Teal Blue Jungle Green Orchid Light Blue Ultramarine Blue Green Raw Umber Macaroni and Cheese Aquamarine Purple Heart Sepia Jazzberry Jam Blush Robin's Egg Blue Copper Yellow-Orange Beaver Middle Blue Purple Brown Green Cadet Blue Orange-Yellow White Brilliant Rose Outer Space Scarlet Cobalt Blue Purple Mountains' Majesty Orange-Yellow Venetian Red Mountain Meadow Maximum Yellow Maximum Yellow Red Desert Sand Maximum Green Maximum Green Razzmatazz Sky Blue Turquoise Blue Indian Red Almond Periwinkle Tickle Me Pink Melon Blue-Gray Jazzberry Jam Yellow-Orange", "Green", "Madder Lake", 1 },
                    { 41, "Middle Blue", "Asparagus Dandelion Blue-Gray Mahogany Violet Middle Red Maximum Yellow Red Pacific Blue Black Medium Rose Blue Bell Yellow-Green Madder Lake Ultramarine Blue Turquoise Blue English Vermilion Green-Blue Eggplant Navy Blue Sunset Orange Burnt Sienna Venetian Red Maximum Green Yellow Cornflower Tropical Rain Forest Robin's Egg Blue Olive Green Robin's Egg Blue Orange Maximum Yellow Red Aquamarine Cerulean Jungle Green Vivid Violet Piggy Pink Apricot Mauvelous Apricot Green-Blue Orange-Yellow Yellow Desert Sand Shamrock Violet-Blue Sea Green Middle Yellow Red Fern Orange Wisteria Wild Strawberry", "Red-Violet", "Red-Orange", 1 },
                    { 31, "Wisteria", "Vivid Tangerine Maximum Purple Inchworm Pacific Blue Sky Blue Brown Blue-Violet Gold Maroon Middle Yellow Aquamarine Mango Tango Robin's Egg Blue Royal Purple Magenta Yellow Dark Venetian Red Cotton Candy Mulberry Fuzzy Wuzzy Blue-Gray Jazzberry Jam Gold Middle Yellow Desert Sand Caribbean Green Vivid Violet Maximum Red Purple English Vermilion Violet-Blue Razzmatazz Blue Bell Teal Blue Desert Sand Blue Sea Green Scarlet Medium Chrome Green Eggplant Middle Blue Green Blush Mulberry Medium Chrome Green Ultramarine Blue Bluetiful Wild Strawberry Light Venetian Red Asparagus Vivid Violet Desert Sand", "Lemon Yellow", "Olive Green", 0 },
                    { 43, "Middle Red", "Lavender Maize Tropical Rain Forest Middle Blue Green Vivid Tangerine Vivid Violet Green-Yellow Charcoal Gray Blue-Gray Burnt Umber Cerulean Blue Tropical Rain Forest Middle Green Yellow Peach Magenta Red-Violet Pink Flamingo White Orchid Scarlet Maximum Green Yellow Mango Tango Maize Middle Red Purple Violet-Blue Blue-Green Maximum Blue Purple Asparagus Middle Blue Green Purple Mountains' Majesty Tan Burnt Sienna Aquamarine Green-Yellow Middle Blue Purple Maize Raw Umber Burnt Sienna Cadet Blue Wisteria Orange-Red Dark Venetian Red Light Blue Maximum Red Purple Light Venetian Red Tickle Me Pink Permanent Geranium Lake Violet-Blue Medium Chrome Green Blush", "Spring Green", "Green-Blue", 0 },
                    { 44, "Yellow-Orange", "Tickle Me Pink Dandelion Permanent Geranium Lake Pink Flamingo Bluetiful Purple Heart Red-Orange Cerulean Maximum Yellow Red Jazzberry Jam Banana Mania Fuchsia Denim Middle Blue Green Maximum Blue Green Middle Red Purple Cerulean Light Blue Purple Heart Sepia Middle Blue Indigo Tumbleweed Pacific Blue Periwinkle Pacific Blue Shamrock Inchworm Medium Chrome Green Maximum Blue Green Yellow-Green Van Dyke Brown Green Sea Green Maximum Yellow Maximum Green Middle Blue Purple Maximum Green Inchworm Fern Blue-Violet Manatee Jungle Green Black Sea Green Beaver Blue-Green Orchid Light Blue Sea Green", "Copper", "Periwinkle", 1 },
                    { 45, "Bittersweet", "Burnt Umber Violet Tan Indigo Charcoal Gray Cobalt Blue Maximum Red Ultramarine Blue Peach Maximum Blue Purple Raw Sienna Medium Chrome Green Charcoal Gray Periwinkle Maroon Pink Flamingo Asparagus Venetian Red Ultramarine Blue Peach Macaroni and Cheese Tumbleweed Indian Red Middle Green Yellow Aquamarine Permanent Geranium Lake Maximum Red Eggplant Middle Red Purple Maximum Red Purple Periwinkle Maximum Green Olive Green Lavender Aquamarine Orchid Caribbean Green Middle Red Maximum Green Yellow Maximum Green Yellow Aquamarine Middle Green Yellow Charcoal Gray Violet-Red Yellow-Green Brilliant Rose Teal Blue Madder Lake Raw Sienna Celestial Blue", "Denim", "Jazzberry Jam", 1 },
                    { 46, "Wisteria", "Razzmatazz Fuzzy Wuzzy Fuchsia Medium Chrome Green Middle Purple Mahogany Maximum Green Tropical Rain Forest Cerise Bluetiful Apricot Shadow Violet-Blue Spring Green Blue Bell Eggplant Midnight Blue Turquoise Blue Navy Blue Maize Middle Blue Red-Orange Wild Strawberry Maximum Green Yellow Eggplant Carmine Antique Brass Canary Fuzzy Wuzzy Vivid Violet Tan Cobalt Blue Light Venetian Red Maximum Red Yellow Red Gray Light Chrome Green Maximum Blue Red-Violet Orange-Yellow Tickle Me Pink Blue-Green Pacific Blue Thistle Beaver Tickle Me Pink Celestial Blue Lavender Thistle", "Middle Blue Green", "Navy Blue", 0 },
                    { 47, "Carnation Pink", "Middle Green Yellow Maximum Purple Cerulean Maximum Yellow Red Brick Red Antique Brass Blue-Gray Violet Tropical Rain Forest Maximum Green Brilliant Rose Red Maximum Blue Green White Maximum Green Yellow Vivid Violet Yellow-Orange Pine Green Middle Blue Orange-Red Orchid Inchworm Light Chrome Green Periwinkle Violet Middle Blue Purple Fuzzy Wuzzy Peach Pink Flamingo Maximum Red Purple Venetian Red Teal Blue Periwinkle White Raw Sienna Desert Sand Razzmatazz Tropical Rain Forest Ultramarine Blue Peach English Vermilion Blue Bell Goldenrod Periwinkle Blush Maize Medium Rose Madder Lake Caribbean Green Scarlet", "Eggplant", "Van Dyke Brown", 0 },
                    { 48, "Middle Purple", "Orange-Yellow Middle Purple Purple Mountains' Majesty Maximum Blue Green Bluetiful Outer Space Mauvelous Maximum Blue Green Mulberry Olive Green Cornflower Silver Venetian Red Cerulean Cerulean Goldenrod Violet Turquoise Blue Gold Middle Purple Middle Yellow Mango Tango Razzmatazz Brick Red Teal Blue Almond Wisteria Maroon Eggplant Banana Mania Burnt Sienna Tan Copper Carnation Pink Shadow Maximum Blue Green Mulberry Banana Mania Mountain Meadow Copper Olive Green Teal Blue Bluetiful Purple Heart Cornflower Maximum Red Vivid Tangerine Mauvelous Granny Smith Apple Raw Umber", "Indigo", "Middle Blue Purple", 1 },
                    { 50, "Cadet Blue", "Pine Green Teal Blue Violet Maximum Green Canary Violet-Blue Orange-Yellow Orange Brilliant Rose Red Brick Red Olive Green Wild Strawberry Sunset Orange Banana Mania Mahogany Granny Smith Apple Cadet Blue Maroon Maroon Gray Charcoal Gray Indian Red Beaver Carnation Pink Pink Sherbert Light Blue Sea Green Yellow Ultramarine Blue Mountain Meadow Robin's Egg Blue Charcoal Gray Celestial Blue Charcoal Gray Red-Orange Salmon Magenta Outer Space Permanent Geranium Lake Thistle Blue-Gray Shamrock Carmine Cerulean Blue Maroon Cerise Goldenrod Yellow Scarlet", "Desert Sand", "Jazzberry Jam", 1 },
                    { 42, "Peach", "Cornflower Outer Space Red Fuchsia Periwinkle Lavender Brilliant Rose Orchid Brown Desert Sand Green Salmon English Vermilion Forest Green Salmon Celestial Blue Cotton Candy Middle Purple Cerulean Blue Inchworm Burnt Orange Cerise Maximum Red Desert Sand Caribbean Green Maximum Blue Peach Mountain Meadow Fern White Raw Sienna Violet Carmine Timberwolf Cerulean Blue Burnt Orange Pacific Blue Green-Blue Gold Middle Yellow Red Turquoise Blue Burnt Orange Plum Venetian Red Fuzzy Wuzzy Medium Chrome Green Maximum Blue Purple Maximum Yellow Vivid Violet Sepia", "Outer Space", "Light Blue", 0 },
                    { 30, "Orange-Red", "Brick Red Middle Green Yellow Middle Blue Cobalt Blue Piggy Pink Sunset Orange Van Dyke Brown Jungle Green Pacific Blue Shadow Blush Indian Red Wild Strawberry Medium Rose Beaver Bluetiful Maximum Blue Green Brilliant Rose Spring Green Goldenrod Spring Green Forest Green Cadet Blue Sunset Orange Red Tumbleweed Middle Yellow Shadow Salmon Black Mango Tango Melon Raw Umber Jungle Green Charcoal Gray Forest Green Blush Jungle Green Forest Green Blue-Violet Caribbean Green Light Venetian Red Brick Red Brilliant Rose Sunset Orange Denim Peach Mango Tango English Vermilion Blue-Violet", "Macaroni and Cheese", "Shadow", 0 },
                    { 28, "Wild Blue Yonder", "Medium Chrome Green Maximum Blue Purple Middle Red Purple English Vermilion Wild Strawberry Cerise Inchworm Cerulean Blue Mountain Meadow English Vermilion Maximum Yellow Red Maximum Yellow Permanent Geranium Lake Indian Red Blush Yellow Light Blue Black Piggy Pink English Vermilion Middle Red Blue Bell Tumbleweed Blue-Green Spring Green Medium Violet Green-Yellow Dark Venetian Red Purple Mountains' Majesty Melon Bittersweet Orchid Fuchsia Middle Yellow Purple Mountains' Majesty Red-Orange Red Mahogany Raw Umber Jazzberry Jam Cerulean Outer Space Red-Violet Brilliant Rose Beaver Middle Red Madder Lake Middle Red Purple Raw Sienna Permanent Geranium Lake", "Maximum Blue Purple", "Tropical Rain Forest", 1 },
                    { 7, "Maximum Green", "Sky Blue Canary Vivid Violet Pacific Blue Cornflower Cornflower Purple Mountains' Majesty Beaver Turquoise Blue Bluetiful Blue Bell Periwinkle Salmon Jazzberry Jam Navy Blue White Maximum Purple Maize Indigo Burnt Orange Burnt Umber Forest Green Indigo Vivid Tangerine Maximum Blue Maximum Yellow Pink Flamingo Mulberry Jungle Green Wild Strawberry Charcoal Gray Light Chrome Green Green Orange Venetian Red Caribbean Green Maximum Green Yellow Periwinkle Raw Sienna Blue Light Venetian Red Blue-Violet Burnt Umber Maximum Yellow Caribbean Green Lavender Maximum Blue Mulberry Canary Plum", "Yellow", "Cerulean Blue", 0 },
                    { 8, "Cerulean", "Middle Yellow Red Violet-Blue Raw Umber Fuchsia Brick Red Carmine Van Dyke Brown Burnt Sienna Mulberry Permanent Geranium Lake Teal Blue Scarlet Wild Strawberry Blue-Gray Light Chrome Green Tan Maximum Blue Green Plum Yellow-Orange Plum Fuzzy Wuzzy Indigo Orange Scarlet Blue-Gray Olive Green Middle Red Purple Plum Purple Mountains' Majesty Jungle Green Purple Heart Gold Purple Mountains' Majesty Mountain Meadow Middle Yellow Red Cerise Outer Space Scarlet Cotton Candy Antique Brass Aquamarine Burnt Orange Middle Yellow Red Sea Green Orange-Yellow Brown Blue Bell Blush Wild Strawberry Black", "Cornflower", "Goldenrod", 1 },
                    { 9, "Maroon", "Lavender Sky Blue Sky Blue Tickle Me Pink Yellow-Green Jazzberry Jam Pink Flamingo Green Fuchsia Venetian Red Antique Brass Middle Red Purple Maximum Red Purple Orange Maize Fuzzy Wuzzy Tan Apricot Wild Blue Yonder Jazzberry Jam Middle Blue Violet-Red Mauvelous Timberwolf Blue Tumbleweed Violet-Blue Periwinkle Burnt Sienna Wild Blue Yonder Olive Green Granny Smith Apple Maximum Yellow Red Brilliant Rose Middle Green Cornflower Tickle Me Pink Medium Rose Periwinkle Pacific Blue Banana Mania Teal Blue Forest Green Tan Light Venetian Red Granny Smith Apple Green Middle Yellow Red Middle Yellow Pink Flamingo", "Brilliant Rose", "Maximum Blue Purple", 0 },
                    { 10, "Antique Brass", "Plum Orchid Mulberry Granny Smith Apple Midnight Blue Pink Sherbert Forest Green Inchworm Desert Sand Timberwolf Violet-Red Green Cotton Candy Wild Strawberry Brick Red Red-Violet English Vermilion Green-Blue Yellow Olive Green Brilliant Rose Cadet Blue Outer Space Middle Green Celestial Blue Mountain Meadow Orchid Burnt Orange Maize English Vermilion Outer Space Maize Bittersweet Indian Red Maroon Vivid Violet Tan Midnight Blue Forest Green Maximum Blue Purple Bluetiful Pink Flamingo Caribbean Green Pine Green Cadet Blue Wild Strawberry Fuchsia Melon Carmine Cadet Blue", "Yellow-Green", "Bittersweet", 1 },
                    { 11, "Vivid Violet", "Mountain Meadow Teal Blue Maximum Yellow Teal Blue Fern Light Chrome Green Shamrock Sky Blue Middle Blue Purple Plum Wisteria Granny Smith Apple Venetian Red Middle Purple Carnation Pink Burnt Sienna Dandelion Melon Charcoal Gray Indian Red Cerulean Vivid Violet Red Maximum Green Yellow Yellow-Green Outer Space Green Wild Blue Yonder Magenta Fern Cerise Dandelion Wisteria Mahogany Gold Jungle Green Indigo Burnt Sienna Maximum Purple Dandelion Middle Red Purple Madder Lake Burnt Umber Maximum Yellow Apricot Blue Bell Red-Violet Indigo Orchid Magenta", "Pink Flamingo", "Light Chrome Green", 0 },
                    { 12, "Light Venetian Red", "Yellow-Orange Apricot Madder Lake Vivid Violet Plum Maximum Yellow Madder Lake Canary Scarlet Jungle Green Turquoise Blue Timberwolf Red Ultramarine Blue Medium Chrome Green Dandelion Tropical Rain Forest Beaver Periwinkle Cerise Caribbean Green Vivid Tangerine Orchid Middle Blue Light Venetian Red Middle Green Yellow Scarlet Medium Violet Thistle Pine Green Maximum Blue Purple Red-Violet Cerise Charcoal Gray Gold Piggy Pink Cornflower Middle Blue Red-Violet Eggplant Brick Red Asparagus Brilliant Rose Dandelion Orange-Yellow English Vermilion Eggplant Razzmatazz Wisteria Dark Venetian Red", "Beaver", "Cotton Candy", 0 },
                    { 13, "Antique Brass", "Apricot Brick Red Maximum Blue Burnt Umber Olive Green Desert Sand Permanent Geranium Lake Middle Blue Purple Piggy Pink Pink Flamingo Middle Purple Middle Blue Green Navy Blue Lemon Yellow Maximum Red Manatee Mahogany Maximum Blue Tickle Me Pink Green-Yellow Middle Green Middle Red Purple Heart Sea Green Venetian Red Middle Blue Green Carmine Wisteria Charcoal Gray Permanent Geranium Lake Magenta Cerulean Blue Bluetiful Pink Sherbert Tumbleweed Fuzzy Wuzzy Plum Mahogany Pacific Blue Asparagus Shamrock Celestial Blue Green-Blue Middle Red Purple Lavender Violet-Red Red Red-Violet Vivid Violet Mango Tango", "Carnation Pink", "Fuzzy Wuzzy", 1 },
                    { 14, "Razzmatazz", "Maize Blue Bell Apricot Burnt Sienna Tickle Me Pink Middle Green Yellow Maximum Blue Green Plum Maximum Green Purple Mountains' Majesty Middle Yellow Raw Sienna Fuchsia Dandelion Blue Blue-Green Wild Strawberry Tropical Rain Forest Blue Cerise Pink Flamingo Robin's Egg Blue Periwinkle Almond Light Blue Orange-Yellow Blue-Green Cornflower Sea Green Maximum Purple Lemon Yellow Banana Mania Caribbean Green Blue-Gray Forest Green Light Venetian Red Maize Violet-Blue Eggplant Pink Flamingo Brown Ultramarine Blue Maximum Blue Permanent Geranium Lake Caribbean Green Dandelion Cadet Blue Purple Mountains' Majesty Sea Green Maximum Blue Green", "Cerulean Blue", "Cerulean Blue", 0 },
                    { 15, "Tropical Rain Forest", "Maroon Copper Brilliant Rose Bluetiful Light Blue Burnt Sienna Middle Purple Orange Maximum Purple Purple Mountains' Majesty Sunset Orange Maximum Blue Purple Lavender Turquoise Blue Pacific Blue Maximum Yellow Midnight Blue Lavender Permanent Geranium Lake Burnt Sienna Brick Red Shamrock Burnt Orange Teal Blue Pacific Blue Gray Cotton Candy Middle Blue Green Thistle Banana Mania Black Raw Umber Van Dyke Brown Pink Sherbert Midnight Blue Carmine Pacific Blue Violet-Blue Orange Black Antique Brass Middle Blue Middle Red Purple Blue-Green Raw Sienna Blue-Gray Sepia Red Brilliant Rose Sepia", "Cerulean Blue", "Middle Purple", 1 },
                    { 16, "Thistle", "Medium Rose Mango Tango Magenta Orange-Yellow Maximum Blue Purple Indigo Vivid Tangerine Middle Green Yellow Silver Mulberry Yellow-Green Middle Red Middle Blue Purple Razzmatazz Red-Orange Blue Bell Thistle Apricot Jazzberry Jam Caribbean Green Permanent Geranium Lake Middle Blue Green Wild Blue Yonder Green Yellow-Green Mulberry Apricot Violet-Blue Cornflower Desert Sand Lemon Yellow Navy Blue Brick Red Sepia Apricot Piggy Pink Green-Blue Raw Sienna Orange English Vermilion Red-Violet Lavender Red-Violet Carnation Pink Thistle Melon Red-Violet Brilliant Rose White Dandelion", "Maximum Blue Purple", "Black", 0 },
                    { 17, "Orchid", "Pacific Blue Lemon Yellow Maximum Blue Fern Maximum Green Yellow Purple Mountains' Majesty Macaroni and Cheese Sepia Blue-Gray Gray Middle Blue Purple Gray Wild Strawberry Medium Rose Violet-Blue Blue Maximum Red Purple Burnt Orange Pacific Blue Royal Purple Plum Light Venetian Red Sky Blue Middle Yellow Red Middle Blue Medium Chrome Green Tan Tan Gray Salmon Cotton Candy Blue-Violet Salmon Cotton Candy Ultramarine Blue Mulberry Maximum Yellow Wisteria Sea Green Cadet Blue Medium Rose Vivid Tangerine Charcoal Gray Maximum Blue Green Medium Rose Orange-Yellow Outer Space Ultramarine Blue Violet-Red Middle Red", "Middle Yellow", "Silver", 0 },
                    { 18, "Violet-Red", "Orange Wild Blue Yonder Apricot Cobalt Blue Silver Desert Sand Middle Blue Purple Ultramarine Blue Maximum Yellow Pacific Blue Green Fuchsia Midnight Blue Orange-Yellow Venetian Red Maximum Blue Green Pink Sherbert Middle Red Tropical Rain Forest Salmon Banana Mania Brick Red Cerulean Blue Blue Bell Pine Green Cerulean Blue Middle Yellow Red Bluetiful Medium Chrome Green Mountain Meadow Cobalt Blue Middle Blue Green Caribbean Green Inchworm Mango Tango Fuchsia Mulberry Violet-Red Wisteria Yellow-Orange Tan Carnation Pink Antique Brass Spring Green Gold Cerulean Blue Yellow Raw Sienna Celestial Blue Magenta", "Sky Blue", "Van Dyke Brown", 0 },
                    { 19, "Salmon", "Yellow-Green Indian Red Blush Red Medium Rose Light Blue Medium Rose Asparagus Pine Green Violet-Blue Mulberry Almond Shadow Madder Lake Midnight Blue Tan Banana Mania Cerulean Blue White Teal Blue Burnt Orange Macaroni and Cheese Yellow-Green Brown Turquoise Blue Melon Sky Blue Timberwolf Middle Yellow Red Periwinkle Gray Tropical Rain Forest Pine Green Mountain Meadow Blue-Gray Mountain Meadow Burnt Orange Banana Mania Ultramarine Blue Wild Strawberry Olive Green Cerulean Blue Lavender Orange-Red Maximum Purple Yellow-Green Canary Permanent Geranium Lake Light Blue Melon", "Blue-Violet", "Fuchsia", 0 },
                    { 20, "Maximum Green Yellow", "Red-Orange Vivid Violet Middle Green Razzmatazz Robin's Egg Blue Tickle Me Pink Middle Purple Maximum Blue Green Raw Umber Gold Blue Cobalt Blue Pink Flamingo Robin's Egg Blue Jungle Green Yellow Timberwolf Maize Carmine Orange Middle Yellow Red Pink Flamingo Middle Purple Mahogany Maximum Red Periwinkle Denim Melon Dandelion Plum Maximum Yellow Red Turquoise Blue Cerulean Blue Pink Flamingo Green Blush Purple Mountains' Majesty Thistle Light Blue Medium Violet Raw Sienna Violet Burnt Orange Blush Tropical Rain Forest Maximum Purple Cobalt Blue Almond Tickle Me Pink Madder Lake", "Magenta", "Salmon", 1 },
                    { 21, "Maximum Red", "Gold Celestial Blue Charcoal Gray Middle Green Carmine Wild Strawberry Middle Blue White Spring Green Gray Red-Orange Bittersweet Blue-Violet Burnt Umber Antique Brass Orange-Yellow Mountain Meadow Maximum Red Middle Purple Sepia Tropical Rain Forest Blue Raw Umber Carmine Salmon Burnt Orange Medium Rose Plum Bittersweet Outer Space Permanent Geranium Lake Jazzberry Jam Pine Green Permanent Geranium Lake Almond Middle Red Maximum Red Purple Blue Maroon Carnation Pink Green-Yellow Middle Blue Green Sepia Light Chrome Green Maximum Blue Purple Van Dyke Brown Pink Sherbert Madder Lake Blue-Green Gray", "Maximum Green", "Sunset Orange", 0 },
                    { 22, "Copper", "Light Chrome Green Jazzberry Jam Antique Brass White Raw Umber Light Chrome Green Tickle Me Pink Violet Fern Blush Maximum Blue Green Sea Green Middle Blue Purple Blush Manatee Apricot Cornflower Lavender Medium Chrome Green Burnt Umber Yellow-Green Light Chrome Green Green-Yellow Yellow Desert Sand Middle Red Purple Goldenrod Canary Blush Orange-Red Pine Green Medium Rose Piggy Pink Spring Green Sea Green Burnt Sienna Light Blue Maximum Green Yellow Medium Chrome Green Carmine Jazzberry Jam Red-Violet Blue-Green Navy Blue Almond Royal Purple Sea Green Sunset Orange Blue Banana Mania", "Middle Green Yellow", "Celestial Blue", 1 },
                    { 23, "Middle Green Yellow", "Royal Purple Shamrock Orange Yellow-Green Blue Bell Middle Yellow Madder Lake Periwinkle Lavender Yellow-Green Violet-Blue Tan Middle Purple Shamrock Antique Brass Raw Umber Cerulean Green Robin's Egg Blue Spring Green Brown Outer Space Green Ultramarine Blue Indigo Tickle Me Pink Teal Blue Pacific Blue Mauvelous Light Venetian Red Yellow-Orange Middle Blue Purple Caribbean Green Periwinkle Cornflower Pink Sherbert Light Blue Middle Yellow Red-Orange Maximum Green Cerise Orange Plum Piggy Pink Caribbean Green Tickle Me Pink Maximum Purple Timberwolf Maximum Blue Purple Goldenrod", "Vivid Violet", "Indian Red", 0 },
                    { 24, "Lavender", "Olive Green Orange-Red Jungle Green Blue-Violet Scarlet Vivid Violet Violet-Blue Black Black Red Jazzberry Jam Indigo Cerise Cerulean Banana Mania Blue-Violet Cornflower Middle Red White Ultramarine Blue Cotton Candy Blue-Violet Red-Orange Green Medium Chrome Green Middle Blue Purple Yellow Blue Bell Aquamarine Pink Sherbert Green-Yellow Gold Medium Chrome Green Melon Permanent Geranium Lake Canary Timberwolf Sunset Orange Black Light Venetian Red Shadow Orchid Black Lavender Middle Purple Beaver Jazzberry Jam Gray Banana Mania Cadet Blue", "Maximum Blue Purple", "Purple Heart", 0 },
                    { 25, "Middle Yellow", "Middle Green Brown Brown Maximum Purple Purple Mountains' Majesty Light Venetian Red Piggy Pink Ultramarine Blue Apricot Periwinkle Canary Maximum Purple Dark Venetian Red Yellow-Orange Yellow-Green Canary Charcoal Gray Maroon Raw Sienna Pacific Blue Caribbean Green Salmon Lemon Yellow Blush Spring Green Inchworm Sepia Navy Blue Tropical Rain Forest Sunset Orange Piggy Pink Maximum Green Cobalt Blue Gold Thistle Brown Orange-Red Red Maximum Yellow Banana Mania Mahogany Thistle Vivid Violet Celestial Blue Maximum Blue Tropical Rain Forest Yellow-Orange Yellow-Orange Yellow-Orange Green-Yellow", "Cobalt Blue", "Maximum Red", 0 },
                    { 26, "Fuzzy Wuzzy", "Blue Bell Violet Turquoise Blue Tumbleweed Maximum Green Yellow Blue-Green Vivid Violet Burnt Sienna Burnt Orange Maximum Red Purple Green-Yellow Burnt Sienna English Vermilion Denim Black Cotton Candy Manatee Maximum Red Purple Jazzberry Jam Silver Teal Blue Maroon Blue-Violet Sepia Green-Yellow Indian Red Yellow Madder Lake Piggy Pink Orange-Yellow English Vermilion Melon Denim Middle Purple Violet Blue-Gray Yellow-Orange Indigo Cobalt Blue Cerulean Orange-Red Maximum Red Purple Medium Rose Cadet Blue Blue Bell Ultramarine Blue Banana Mania Red-Violet Red-Violet Salmon", "Almond", "Fuchsia", 0 },
                    { 27, "Brown", "Fuchsia Salmon Light Blue Mango Tango Sunset Orange Maximum Green Yellow Wisteria Middle Red Green Canary Jazzberry Jam Blush Burnt Orange Middle Purple Blush Maximum Red Tumbleweed Tan Sunset Orange Middle Blue Wild Blue Yonder English Vermilion Light Venetian Red Red-Orange Plum White Brown Green-Blue Blue-Violet Tumbleweed Light Chrome Green Maroon Light Blue Orange Mauvelous Midnight Blue Forest Green Black Lavender Maximum Green Yellow Green-Yellow Brilliant Rose Purple Mountains' Majesty Green-Blue Maize Permanent Geranium Lake Outer Space Yellow Maximum Purple Middle Purple", "English Vermilion", "Carnation Pink", 1 },
                    { 29, "Periwinkle", "Red-Orange Purple Mountains' Majesty Carnation Pink Sepia Vivid Violet Tickle Me Pink Fuzzy Wuzzy Navy Blue Medium Violet Green-Blue Manatee Black Orange-Red Gray Shamrock Dandelion Violet-Red Maximum Blue Purple Pine Green Salmon Dark Venetian Red Mauvelous Maximum Purple Turquoise Blue Olive Green Maximum Green Yellow Celestial Blue Thistle Mountain Meadow Cobalt Blue Brick Red Inchworm Lavender Aquamarine Gray Indian Red Tumbleweed Maximum Blue Maize Jazzberry Jam Venetian Red Maroon Timberwolf Maroon Van Dyke Brown Venetian Red Fuchsia Eggplant Gold Magenta", "Mahogany", "Wild Blue Yonder", 1 },
                    { 6, "Jungle Green", "Mulberry Sky Blue Madder Lake Fuzzy Wuzzy Blue-Gray Blush Canary Bittersweet Jazzberry Jam Inchworm Orchid Bittersweet Aquamarine Canary Orange Carmine Wild Strawberry Mango Tango Turquoise Blue Mauvelous Maroon Purple Heart Burnt Orange Purple Mountains' Majesty English Vermilion Carnation Pink Thistle Tumbleweed Denim Middle Blue Purple Piggy Pink Middle Blue Purple Tropical Rain Forest Yellow Charcoal Gray Peach Orange-Yellow Peach Cerulean Cotton Candy Mahogany Orchid Light Blue Middle Green Brilliant Rose Antique Brass Mahogany Forest Green Sunset Orange Razzmatazz", "Maximum Red Purple", "Maximum Yellow Red", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 50);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1,
                columns: new[] { "Breed", "Description", "Name", "Species" },
                values: new object[] { "I dunno, cat", "Fat & mean, you'll love him.", "Steve", "Cat" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                columns: new[] { "Breed", "Description", "Name", "Species", "Status" },
                values: new object[] { "Beagle", "Just one of the worst dogs, but also one of the best? A study in contradictions.", "Six Hotdogs", "Dog", 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3,
                columns: new[] { "Breed", "Description", "Name", "Species", "Status" },
                values: new object[] { "Chihuahua", "Annoying, mean, won't stop shaking, growls at everything, please help us", "Toes under the escalator", "Dog", 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4,
                columns: new[] { "Breed", "Description", "Name", "Species", "Status" },
                values: new object[] { "Fat", "Queen Salt has to have her chicken precisely at 5pm or you will get scratched. She has thumbs!", "Salt", "Cat", 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5,
                columns: new[] { "Breed", "Description", "Name", "Species" },
                values: new object[] { "Dachshund", "Loves a good burger", "Whataburger", "Dog" });
        }
    }
}
