﻿using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace artificially_infused.Controllers.game
{
    public class PromptsRepository
    {
        public List<string> Prompts = new List<string>
        {
            "Several wild {NOUNS} eating {FOOD} while taking a bubble bath.",
            "A {ADJECTIVE} nun throwing a wild party at {LOCATION}.",
            "A magical potion that morphs {NOUN} into {NOUN}.",
            "A {NOUN} riding a unicycle while juggling multiple {NOUN}.",
            "An extraterrestrial creature playing chess with a {NOUN} on a floating {LOCATION} made of candy.",
            "A baby {NOUN} picking its nose and hiding it behind {LOCATION}.",
            "Sentient cupcakes having a heated debate about {NOUN} with a wise old {NOUN} moderating the discussion.",
            "In New York City, you can find a secret society of {NOUN} who hold regular meetings on top of {NOUN} to discuss their latest strategies for perfecting the art of {NOUN}.",
            "Group of cowboys eating {FOOD} while riding on a {NOUN} in {LOCATION}.",
            "A penguin having a tea party with {NOUN} on top of a giant mountain.",
            "A robot is teaching a group of {NOUN} how to {VERB} in a disco.",
            "An old man eating way too much {FOOD} while dancing the macarena.",
            "Flying {NOUN} wearing a top hat and sipping a cup of tea while being chased by a fleet of UFOs.",
            "The {NOUN} party has a strict dress code – feathered tuxedos and tiny top hats are a must for all attendees!",
            "DJ spinning a track that makes the crowd get {ADJECTIVE}.",
            "In Pittsburgh, there's a legendary annual event where residents engage in a fierce competition to see who can build the tallest {NOUN} made entirely of pierogies.",
            "The 'Steel City Stand-Up' competition is where contestants showcase their best jokes about {NOUN}.",
            "The 'Terrible Towel Tango' is a Pittsburgh dance competition where participants must wear {NOUN} while dancing.",
            "Pittsburghers love syncronized dancing, jazz hands, and {NOUN}.",
            "A whimsical contest where participants compete to throw {NOUN} through a ring.",
            "Deep under the ocean {NOUN} plays with the mermaids.",
            "A {NOUN} wearing sunglasses and riding a {NOUN}.",
            "A pizza flying in outer space with {NOUN}.",
            "A {ADJECTIVE} giraffe playing basketball against a {NOUN}.",
            "A muppet doing stand-up comedy for an audience of {NOUN} clones.",
            "A superhero {NOUN} saving the day in {FOOD} city.",
            "A grumpy-looking {FOOD} attending a birthday party for llamas.",
            "A {NOUN} blowing out the candles on the birthday cake.",
            "A dancing {NOUN} with a sombrero at a fiesta.",
            "A group of {NOUN} having a wild dance party.",
            "A {ADJECTIVE} dragon reading a bedtime story to a group of teddy bears.",
            "A confused robot trying to understand {ADJECTIVE} {FOOD}.",
            "A ninja {NOUN} practicing martial arts in {ADJECTIVE} jungle.",
            "A late night disco party with {NOUN} and {NOUN}.",
            "A sneezing elephant creating a huge {FOOD} explosion.",
            "A {NOUN} having a tea party stuffed NOUNs.",
            "A sassy {NOUN} doing goat yoga in a peaceful meadow.",
            "A {ADJECTIVE} monkey in a spacesuit exploring a world made of {FOOD}.",
            "A wild pirate kitten searching for {FOOD} on a sandy beach.",
            "A smiling {FOOD} sunbathing on mars.",
            "A {ADJECTIVE} cactus at a {NOUN} show in the desert.",
            "A karate-chopping {NOUN} in a martial arts tournament.",
            "A friendly ghost offering {NOUN} to kids.",
            "A slimy snail racing a {NOUN} at the {LOCATION}.",
            "A scorching hot cup of coffee participating in a marathon with {NOUN}.",
            "A group of {NOUN} friends roasting each other over a {ADJECTIVE} campfire under the moon.",
            "A {NOUN} playing a magic violin made of {ADJECTIVE} {FOOD}",
            "A hairless cat detective solving the mystery of the {ADJECTIVE} {NOUN}",
            "A {NOUN} playing an electric guitar underwater with {NOUN}",
            "A talking {NOUN} hosting a late-night talk show about {NOUN}",
            "A {ADJECTIVE} scientist conducting experiments on {NOUN} in a laboratory in the mountains.",
            "A group of {ADJECTIVE} {FOOD} creating the ultimate KISS cover band",
            "A {NOUN} taking a bubble bath in a boiling tub of oil and {NOUN}.",
            "A sophisticated {FOOD} attending a black-tie gala, complete with a monocle and {NOUN}.",
            "A rebellious {FOOD} attempting a daring escape from a {ADJECTIVE} kitchen",
            "A {ADJECTIVE} coffee cup pulling pranks on {NOUN} in a lively cafeteria.",
            "A stinky avocado hosting a talk show for {NOUN} and {NOUN}.",
            "A group of kittens in virtual reality headsets playing a game with {NOUN}",
            "A wise old cheese wheel imparting cheesy advice to a group of {NOUN}.",
            "A {ADJECTIVE} rubber duck leading a team of {NOUN} explorers on a quest for {FOOD}.",
            "A tv show featuring {ADJECTIVE} {NOUN} portrayed by soap bars.",
            "A rockstar broccoli shredding it on a guitar in front of a cheering crowd of {NOUN}.",
            "A shy slice of bread nervously giving a toast at a wedding of {NOUN} and {NOUN}.",
            "A fierce pancake warrior battling against a {ADJECTVE} opponent in a duel to the death.",
            "A rollerblading tomato running from the {NOUN} police.",
            "{NOUN} eating a radioactive donut.",
            "A {ADJECTIVE} rubber chicken {VERB} across the the planet.",
            "Americans love to {VERB} {ADJECTIVE} {FOOD}.",
            "A flamenco-dancing {FOOD} {VERB} on the highway.",
            "A whale lifeguard diligently watching over a pool filled with {NOUN}",
            "A {ADJECTIVE} potato strutting down the runway on mars.",
            "A {NOUN} on a tightrope, balancing on a string of dental floss.",
            "{NOUN} brushing their teeth with a {ADJECTIVE} {NOUN}.",
            "A {FOOD} detective solving mysterious {FOOD} murders in Food City.",
            "The moon cracking eggs to make breakfast for {NOUN}",
            "A flamboyant {NOUN} leading a conga line of {FOOD} at a beach party.",
            "The internationAL space station orbiting the planet {NOUN}.",
            "A {LOCATION} loving donut {VERB} under a glittering disco ball.",
            "A sushi chef {NOUN} creating {FOOD} with ninja-like precision.",
            "A charismatic slice of buffalo chicken pizza {VERB} a cooking show for {NOUN}.",
            "Forest Gump wearing a {ADJECTIVE} {NOUN} mask. ",
            "All of the US Presidents wearing {ADJECTIVE} {NOUN}.",
            "A skateboard-riding {NOUN} performing {ADJECTIVE} tricks at the Olypmics.",
            "A circus of {FOOD} {VERB} their acrobatic skills under a candy big top",
            "A {ADJECTIVE} astronaut {VERB} extraterrestrial invaders on the surface of {LOCATION}.",
            "An elite team of {ADJECTIVE} hackers infiltrating a high-security virtual {LOCATION}.",
            "A renegade detective {VERB} a {ADJECTIVE} assassin through a {ADJECTIVE} city.",
            "A group of {NOUN} exploring a {ADJECTIVE} temple filled with deadly {NOUN}.",
            "James Bond {VERB} into a {ADJECTIVE} underwater base to fight {NOUN}.",
            "A martial arts {FOOD} confronting an army of robotic {NOUN} in a neon-lit dojo.",
            "A {LOCATION} survivor leading a rebellion against a tyrannical {NOUN} overlord.",
            "A daring heist on a high-speed train hurtling through a {LOCATION} landscape.",
            "Steve the time-traveling detective solving crimes across different {ADJECTIVE} {LOCATION}.",
            "A submarine captain navigating treacherous waters to uncover the plot of the {ADJECTIVE} {FOOD}.",
            "A {ADJECTIVE} {NOUN} battling a giant monster in the heart of a bustling {LOCATION}.",
            "A race against time as a bomb squad defuses explosive {NOUN} in a crowded stadium.",
            "A legendary swordswoman facing off against a {ADJECTIVE} {NOUN} in a mystical forest.",
            "A rogue space explorer discovering a hidden {FOOD} civilization on the distant planet of {LOCATION}.",
            "A team of crack {NOUN} mercenaries rescuing hostages from a high-rise skyscraper under siege.",
            "A car chase through the winding streets of {LOCATION}.",
            "A parkour expert {NOUN} navigating a futuristic cityscape while being pursued by assassins.",
            "A military special forces unit {VERB} an enemy stronghold in the heart of the {LOCATION}.",
            "A vigilante hero patrolling the sewers of a {LOCATION} with no crime.",
            "A {ADJECTIVE} detective solving a series of murders in a neon-soaked dystopia of {LOCATION}.",
            "A team of {NOUN} archaeologists facing ancient curses and {ADJECTIVE} entities in a tomb raid.",
            "A space cowboy engaging in a zero-gravity shootout with {NOUN} in {LOCATION}. ",
            "A renegade pilot dogfighting against alien spacecraft in the skies above Earth while eating {FOOD}. ",
            "A high-stakes poker game between {NOUN} and {NOUN} with world-altering secrets at stake.",
            "A {ADJECTIVE} {NOUN} facing off against a pack of genetically enhanced predators.",
            "A mountain climber scaling a {ADJECTIVE} peak while pursued by an international crime syndicate of {NOUN}.",
            "A submarine race against rival factions to recover a {ADJECTIVE} {NOUN} from the ocean depths.",
            "A team of ex-military mercenary {NOUN} hired for a covert mission in a war-torn {LOCATION}.",
            "A rogue AI unleashing chaos in {LOCATION}, forcing a {ADJECTIVE} programmer to stop it.",
            "A lone sniper perched atop a skyscraper, targeting a criminal mastermind in a crowded square.",
            "A scientist racing against time to prevent a {ADJECTIVE} {NOUN} from spreading across the globe.",
            "A master thief orchestrating a series of heists to expose corruption within {LOCATION}.",
            "A paranormal investigator facing {ADJECTIVE} {NOUN} in an abandoned asylum.",
            "A group of survivors battling mutant {FOOD} in a post-nuclear wasteland.",
            "A deep-sea expedition uncovering ancient {NOUN} in the uncharted depths of {LOCATION}.",
            "A {ADJECTIVE} mercenary tracking down a warlord through a sun-scorched wilderness of {LOCATION}.",
            "A space archaeologist discovering a {ADJECTIVE} alien civilization of {NOUN} on an isolated planet.",
            "A cybernetically enhanced soldier on a mission to neutralize a terrorist threat.",
            "A {ADJECTIVE} treasure hunter exploring a {ADJECTIVE} booby-trapped tomb for a {ADJECTIVE} artifact.",
            "A {ADJECTIVE} con artist orchestrating an {ADJECTIVE} heist during a high-society event.",
            "A {FOOD} riding a {NOUN} in outer space.",
            "A {NOUN} having a picnic with a group of {NOUN}.",
            "A {LOCATION} playing {NOUN} in a tropical paradise.",
            "An {NOUN} giving a {LOCATION} a piggyback ride.",
            "A {NOUN} and a {NOUN} having a dance-off.",
            "A {NOUN} wearing a {NOUN} and playing {NOUN}.",
            "A {FOOD} riding a {NOUN} through a field of {NOUN}.",
            "A {FOOD} having a tea party with {NOUN}.",
            "A {NOUN} doing yoga with a {NOUN}.",
            "A {NOUN} surfing on a {NOUN} in the {LOCATION}.",
            "A cheerful {NOUN} playing {NOUN} in a magical forest.",
            "A clumsy {NOUN} trying to balance on a {NOUN}.",
            "An adventurous {NOUN} exploring a {NOUN} made of candy.",
            "A curious {NOUN} having a conversation with a talking {NOUN}.",
            "A superhero {NOUN} saving the day with their incredible {FOOD} powers.",
            "A group of {NOUN} having a {NOUN} on a sunny beach.",
            "A mischievous {NOUN} pulling pranks on their {NOUN} friends.",
            "A futuristic {NOUN} riding a hoverboard through a bustling {NOUN}.",
            "A friendly {NOUN} having a picnic with a bunch of {NOUN}.",
            "A stylish {NOUN} wearing a {NOUN} and dancing at a {NOUN} party.",
            "A wise old {NOUN} giving advice to a group of {NOUN}.",
            "A {NOUN} having a tea party with a group of tiny {NOUN}.",
            "A team of {NOUN} playing a high-energy game of {NOUN}.",
            "A pair of {NOUN} having a romantic dinner under a sky filled with {NOUN}.",
            "A clumsy {NOUN} trying to juggle {NOUN} in a busy marketplace.",
            "A group of {NOUN} building a {NOUN} out of oversized {NOUN}.",
            "A fashionable {NOUN} strutting down a runway with a collection of {NOUN}.",
            "An eccentric {NOUN} creating a potion with ingredients like {NOUN} and {NOUN}.",
            "A trio of {NOUN} riding scooters through a city made of {NOUN}.",
            "A {NOUN} and a {NOUN} having a hilarious {NOUN} contest.",
            "A {NOUN} in a superhero costume rescuing a group of {NOUN} from danger.",
            "A {NOUN} having a dance-off with a {NOUN} on a rainbow-colored stage.",
            "A magical {NOUN} casting spells to create a rainbow made of {NOUN}.",
            "A {NOUN} in a hot air balloon exploring a sky filled with floating {NOUN}.",
            "A team of {NOUN} playing a game of {NOUN} in zero gravity.",
            "A {NOUN} and a {NOUN} having a playful water fight in a giant {NOUN}.",
            "A group of {NOUN} performing a comedy show for a crowd of {NOUN}.",
            "A {NOUN} and a {NOUN} on a roller coaster ride through a {NOUN}.",
            "A {NOUN} on a skateboard performing tricks on a halfpipe made of {NOUN}.",
            "A {NOUN} and a {NOUN} hosting a cooking show featuring wild {NOUN}.",
            "A {NOUN} in a detective hat solving a mystery involving missing {NOUN}.",
            "A {NOUN} and a {NOUN} going on a road trip in a colorful {NOUN}.",
            "A {NOUN} wearing a crown and ruling over a kingdom of {NOUN}.",
            "A {NOUN} in a spacesuit exploring a planet filled with strange {NOUN}.",
            "A {NOUN} playing a guitar in a band of singing {NOUN}.",
            "A {NOUN} and a {NOUN} having a friendly race in {NOUN}.",
            "A {NOUN} playing a game of {NOUN} against a competitive {NOUN}.",
            "A {NOUN} giving a motivational speech to a group of {NOUN}.",
            "A {NOUN} and a {NOUN} having a dance party in a {NOUN}.",
            "A {NOUN} creating art with a palette of vibrant {NOUN}.",
            "A {NOUN} playing a game of {NOUN} in an enchanted forest.",
            "A {NOUN} and a {NOUN} having a humorous debate about {NOUN}.",
            "A {NOUN} surfing on a wave made of {NOUN}.",
            "A {NOUN} and a {NOUN} hosting a talent show with {NOUN} acts.",
            "A {NOUN} in a wizard hat casting spells with a wand made of {NOUN}.",
            "A {NOUN} riding a magical carpet through a sky filled with {NOUN}.",
            "A {NOUN} playing hide-and-seek with a group of tiny {NOUN}.",
            "A {NOUN} and a {NOUN} having a friendly archery competition.",
            "A {NOUN} and a {NOUN} on a tandem bike ride through a field of {NOUN}.",
            "A {NOUN} and a {NOUN} building a sandcastle on a beach with {NOUN}.",
            "A {NOUN} and a {NOUN} sharing a giant {NOUN} at a carnival.",
            "A {NOUN} and a {NOUN} having a conversation in a garden of blooming {NOUN}.",
            "A {NOUN} playing hopscotch in a park filled with colorful {NOUN}.",
            "A {NOUN} and a {NOUN} on a hot air balloon ride over a landscape of {NOUN}.",
            "A {NOUN} and a {NOUN} having a friendly tug-of-war with a {NOUN}.",
            "A {NOUN} and a {NOUN} participating in a thrilling {NOUN} race.",
            "A {NOUN} and a {NOUN} having a lively debate on a giant {NOUN}.",
            "A {NOUN} and a {NOUN} on a tandem skydiving adventure.",
            "A {NOUN} playing a harmonica in a band of musical {NOUN}.",
            "A {NOUN} and a {NOUN} having a hilarious karaoke competition.",
            "A {NOUN} and a {NOUN} playing a game of {NOUN} on a vibrant {NOUN}.",
            "A {NOUN} and a {NOUN} having a tea party with a collection of unique {NOUN}.",
            "A {NOUN} playing a game of {NOUN} with a group of friendly {NOUN}.",
            "A {NOUN} and a {NOUN} having a picnic in a meadow filled with blooming {NOUN}.",
            "A {NOUN} and a {NOUN} on a roller coaster ride through a vibrant {NOUN}.",
            "A {NOUN} and a {NOUN} having a humorous debate about {NOUN}.",
            "A {NOUN} in a superhero costume saving a group of {NOUN} from danger.",
            "A {NOUN} and a {NOUN} having a dance-off on a rainbow-colored stage.",
            "A {NOUN} casting spells to create a rainbow made of {NOUN}.",
            "A {NOUN} in a hot air balloon exploring a sky filled with floating {NOUN}.",
            "A {NOUN} playing a game of {NOUN} in zero gravity.",
            "A {NOUN} and a {NOUN} having a playful water fight in a giant {NOUN}.",
            "A {NOUN} performing a comedy show for a crowd of {NOUN}.",
            "A {NOUN} and a {NOUN}"
        };

        public List<string> Nouns = new List<string>
        {
            "Table","Chair","Book","Lamp","Plate","Fork","Spoon","Knife","Refrigerator","Television","Couch","Pillow","Blanket","Clock","Mirror","Towel","Soap","Shampoo","Toothbrush","Toothpaste","Shoes","Socks","Pants","Shirt","Hat","Glasses","Computer","Mouse","Keyboard","Monitor","Phone","Wallet","Keys","Pen","Pencil","Paper","Notebook","Backpack","Camera","Headphones","Charger","Battery","Candle","Matches","Vase","Flower","Plant","Window","Door","Carpet","Rug","Tablecloth","Napkin","Dish","Cup","Mug","Bowl","Spoon","Fork","Knife","Dishwasher","Oven","Stove","Microwave","Coffee maker","Blender","Trash can","Broom","Dustpan","Mop","Bucket","Sponge","Detergent","Vacuum","Duster","Coat","Umbrella","Raincoat","Boots","Gloves","Scarf","Watch","Ring","Bracelet","Necklace","Earrings","Wallet","Belt","Sunglasses","Hat","Backpack","Handbag","Wallet","Umbrella","Cell phone","Laptop","Tablet","Headphones","Charger","Battery","Pen","Pencil","Notebook","Calendar","Clock","Lamp","Lightbulb","Desk","Chair","File cabinet","Trash can","Recycling bin","Plant","Picture frame","Poster","Artwork","Mirror","Curtain","Blinds","Carpet","Rug","Pillow","Blanket","Sheets","Mattress","Dresser","Closet","Hanger","Laundry basket","Laundry detergent","Iron","Ironing board","Sewing machine","Thread","Needle","Scissors","Tape","Glue","Stapler","Paperclip","Envelope","Stamp","Postcard","Letter","Package","Box","Bag","Backpack","Suitcase","Map","Compass","Sunglasses","Hat","Sunscreen","Towel","Swimsuit","Beach ball","Sand bucket","Shovel","Flip-flops","Snorkel","Mask","Fins","Beach towel","Cooler","Picnic blanket","Basket","Thermos","Napkin","Plate","Cup","Utensils","Grill","Charcoal","Lighter","Tent","Sleeping bag","Lantern","Flashlight","Binoculars","Camera","Hiking boots","Backpack","Compass","Map","Water bottle","Sunglasses","Hat","Jacket","Raincoat","Umbrella","Bug spray","First aid kit","Snack","Blanket","Pillow","Book","Journal","Pen","Camera"
        };

        public List<string> Verbs = new List<string>
        {
            "Run","Jump","Eat","Sleep","Sing","Dance","Write","Read","Speak","Laugh","Cry","Swim","Climb","Build","Paint","Draw","Cook","Bake","Play","Fly","Drive","Talk","Listen","Explore","Hike","Surf","Ski","Surf","Code","Think","Create","Design","Sculpt","Plant","Craft","Solve","Teach","Learn","Invent","Discover","Invent","Investigate","Succeed","Fail","Relax","Meditate","Exercise","Train","Study","Collaborate","Reflect","Observe","Analyze","Contribute","Sing","Act","Perform","Direct","Capture","Edit","Modify","Experience","Adapt","Compete","Volunteer","Improve","Achieve","Attend","Organize","Plan","Implement","Navigate","Participate","Communicate","Cooperate","Solve","Celebrate","Inspire","Influence","Adapt","Play","Connect","Share","Express","Support","Promote","Advocate","Elevate","Foster","Nurture","Lead","Follow","Delegate","Achieve","Stimulate","Motivate","Experiment","Record","Imagine","Conquer"
        };

        public List<string> Locations = new List<string>
        {
            "New York City","Tokyo","London","Paris","Beijing","Los Angeles","Moscow","Shanghai","Istanbul","Mumbai","Cairo","Rio de Janeiro","Sydney","Toronto","Dubai","Singapore","Seoul","Berlin","Mexico City","Bangkok","USA","Japan","United Kingdom","France","China","USA","Russia","China","Turkey","India","Egypt","Brazil","Australia","Canada","UAE","Singapore","South Korea","Germany","Mexico","Thailand","Mount Everest","Amazon Rainforest","Victoria Falls","The Sahara Desert","The Great Barrier Reef","Rocky Mountains","The Grand Canyon","Mariana Trench","The Great Plains","The Nile River","The Alps","The Great Rift Valley","The Dead Sea","The Andes Mountains","The Galápagos Islands","The Gobi Desert","The Everglades","The Arctic Circle","The Antarctic Peninsula","The Danube River"
        };

        public List<string> Food = new List<string>
        {
            "Pizza","Sushi","Burger","Pasta","Tacos","Ice Cream","Fried Chicken","Chocolate Cake","Salad","Hot Dog","Lobster","Dim Sum","Pancakes","Shrimp Scampi","Chicken Parmesan","Miso Soup","Pad Thai","Clam Chowder","Lasagna","Donuts","Gyro","Croissant","Ceviche","Risotto","Tiramisu","Fish and Chips","Poutine","Nachos","Guacamole","Falafel","Paella","Caesar Salad","French Onion Soup","Goulash","Empanadas","Quiche","Hamburger Steak","Beef Stroganoff","Peking Duck","Jambalaya","Creme Brulee","Cannoli","Gyoza","Chimichanga","Lobster Roll","Chicken Alfredo","Pulled Pork Sandwich","Caprese Salad","Baklava","Eggs Benedict","Calzone","Tom Yum Soup","Fajitas","Beef Wellington","Baba Ganoush","Ratatouille","Margherita Pizza","Mousse","Spring Rolls","Lobster Bisque","Grilled Cheese Sandwich","Pita Bread","Borscht","Pastrami Sandwich","Cucumber Rolls","Macarons","Bagel with Lox","Avocado Toast","Oysters Rockefeller","Pecan Pie","Muffuletta","Omelette","Tempura","Kebab","Minestrone Soup","Peking Duck","Beef Bulgogi","Clams Casino","Chicken Shawarma","Spanakopita","Baklava","Croque Monsieur","Stuffed Grape Leaves","Chicken Katsu","Croque Madame","Gumbo","Pommes Frites","Falafel Wrap","Lobster Mac and Cheese","Chicken Quesadilla","Chicken Satay","Chicken Piccata","Chicken Teriyaki","Chicken Marsala","Ratatouille","Shrimp Po' Boy","Beef Tacos","Lamb Gyro","Cabbage Rolls","Chicken Enchiladas","Crab Cakes","Lobster Thermidor","Philly Cheesesteak","Chicken Caesar Salad","Greek Salad","Caprese Salad","Caesar Salad","Waldorf Salad","Cobb Salad","Nicoise Salad","Tuna Tartare","Caprese Salad","Antipasto Platter","Deviled Eggs","Sashimi Platter","Meze Platter","Fruit Salad","Potato Salad","Coleslaw","Macaroni Salad","Egg Salad","Quinoa Salad","Tabouleh","Bean Salad","Waldorf Salad","Greek Salad","Caesar Salad","Cobb Salad","Tuna Salad","Chicken Salad","Shrimp Salad"
        };

        public List<string> Adjectives = new List<string>
        {
            "able","abnormal","above average","absent-minded","adventurous","affectionate","agile","agreeable","alert","amazing","ambitious","amiable","amusing","analytical","angelic","apathetic","apprehensive","ardent","artificial","artistic","assertive","attentive","average","awesome","awful","balanced","beautiful","below average","beneficent","blue","blunt","boisterous","brave","bright","brilliant","buff","callous","candid","cantankerous","capable","careful","careless","caustic","cautious","charming","cheerful","chic","childish","childlike","churlish","circumspect","civil","clean","clever","clumsy","coherent","cold","competent","composed","conceited","condescending","confident","confused","conscientious","considerate","content","cool","cool-headed","cooperative","cordial","courageous","cowardly","crabby","crafty","cranky","crass","critical","cruel","curious","cynical","dainty","decisive","deep","deferential","deft","delicate","delightful","demonic","demure","dependent","depressed","devoted","dextrous","diligent","direct","dirty","disagreeable","discerning","discreet","disruptive","distant","distraught","distrustful","dowdy","dramatic","dreary","drowsy","drugged","drunk","dull","dutiful","eager","earnest","easy-going","efficient","egotistical","elfin","emotional","energetic","enterprising","enthusiastic","evasive","even-tempered","exacting","excellent","excitable","experienced","fabulous","fastidious","ferocious","fervent","fiery","flabby","flaky","flashy","frank","friendly","funny","fussy","generous","gentle","gloomy","gluttonous","good","grave","great","groggy","grouchy","guarded","hateful","hearty","helpful","hesitant","hot-headed","hypercritical","hystericalidiotic","idle","illogical","imaginative","immature","immodest","impatient","imperturbable","impetuous","impractical","impressionable","impressive","impulsive","inactive","incisive","incompetent","inconsiderate","inconsistent","indefatigable","independent","indiscreet","indolent","industrious","inexperienced","insensitive","inspiring","intelligent","interesting","intolerant","inventive","irascible","irritable","irritating","jocular","jovial","joyous","judgmental","keen","kind","lame","lazy","lean","leery","lethargic","level-headed","listless","lithe","lively","local","logical","long-winded","lovable","love-lorn","lovely","maternal","mature","mean","meddlesome","mercurial","methodical","meticulous","mild","miserable","modest","moronic","morose","motivated","musical","naive","nasty","natural","naughty","negative","nervous","noisy","normal","nosy","numb","obliging","obnoxious","old-fashioned","one-sided","orderly","ostentatious","outgoing","outspoken","passionate","passive","paternal","paternalistic","patient","peaceful","peevish","pensive","persevering","persnickety","petulant","picky","plain","plain-speaking","playful","pleasant","plucky","polite","popular","positive","powerful","practical","prejudiced","pretty","proficient","proud","provocative","prudent","punctual","quarrelsome","querulous","quick","quick-tempered","quiet","realistic","reassuring","reclusive","reliable","reluctant","resentful","reserved","resigned","resourceful","respected","respectful","responsible","restless","revered","ridiculous","sad","sassy","saucy","sedate","self-assured","selfish","sensible","sensitive","sentimental","serene","serious","sharp","short-tempered","shrewd","shy","silly","sincere","sleepy","slight","sloppy","slothful","slovenly","slow","smart","snazzy","sneering","snobby","sober","somber","sophisticated","soulful","soulless","sour","spirited","spiteful","stable","staid","steady","stern","stoic","striking","strong","stupid","sturdy","subtle","sulky","sullen","supercilious","superficial","surly","suspicious","sweet","tactful","tactless","talented","testy","thinking","thoughtful","thoughtless","timid","tired","tolerant","touchy","tranquil","ugly","unaffected","unbalanced","uncertain","uncooperative","undependable","unemotional","unfriendly","unguarded","unhelpful","unimaginative","unmotivated","unpleasant","unpopular","unreliable","unsophisticated","unstable","unsure","unthinking","unwilling","venal","versatile","vigilant","volcanic","vulnerable","warm","warmhearted","wary","watchful","weak","well-behaved","well-developed","well-intentioned","well-respected","well-rounded","willing","wonderful","zealous"
        };

        public List<string> Styles = new List<string>
        {
            "Oil Painting","Expressionism","Anime","Origami","Photographic","Digital","Neon Punk","Isometric","3D Model","Pixel Art"
        };
    }
}