using System;
using System.Collections.Generic;
using System.Linq;
class RandomScriptures
{
    private Dictionary<string, string> _scriptures;

    public RandomScriptures()
    {
        _scriptures = new Dictionary<string, string>();

        _scriptures.Add("John 3:16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        _scriptures.Add("1 Corinthians 13:13", "And now abideth faith, hope, charity, these three; but the greatest of these is charity.");
        _scriptures.Add("James 1:5", "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him.");
        _scriptures.Add("1 Nephi 3:7", "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        _scriptures.Add("Alma 38:10-12",
                        "10 And now, as ye have begun to teach the word even so I would that ye should continue to teach; and I would that ye would be diligent and temperate in all things.\n" +
                        "11 See that ye are not lifted up unto pride; yea, see that ye do not boast in your own wisdom, nor of your much strength.\n" +
                        "12 Use boldness, but not overbearance; and also see that ye bridle all your passions, that ye may be filled with love; see that ye refrain from idleness.");
    }

    public Scripture GetRandomScripture()
    {
        Random random = new Random();
        int index = random.Next(_scriptures.Count);
        KeyValuePair<string, string> randomScripture = _scriptures.ElementAt(index);

        string[] referenceParts = randomScripture.Key.Split(' ');
        string book = referenceParts[0];
        string[] chapterVerseParts = referenceParts[1].Split(':');
        int chapter = int.Parse(chapterVerseParts[0]);
        int verse = int.Parse(chapterVerseParts[1]);

        return new Scripture(book, chapter, verse, randomScripture.Value);
    }
}