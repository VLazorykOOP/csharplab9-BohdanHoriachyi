using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MusicCatalog
{
    public partial class Form4 : Form
    {
        private Hashtable catalog = new Hashtable();

        public Form4()
        {
            InitializeComponent();
        }

        private void buttonAddDisk_Click(object sender, EventArgs e)
        {
            string diskName = textBoxDisk.Text.Trim();
            if (!catalog.ContainsKey(diskName))
            {
                catalog[diskName] = new List<Song>();
                listBoxOutput.Items.Add($"Диск '{diskName}' додано.");
            }
        }

        private void buttonRemoveDisk_Click(object sender, EventArgs e)
        {
            string diskName = textBoxDisk.Text.Trim();
            if (catalog.ContainsKey(diskName))
            {
                catalog.Remove(diskName);
                listBoxOutput.Items.Add($"Диск '{diskName}' видалено.");
            }
        }

        private void buttonAddSong_Click(object sender, EventArgs e)
        {
            string diskName = textBoxDisk.Text.Trim();
            if (catalog.ContainsKey(diskName))
            {
                var song = new Song(textBoxTitle.Text, textBoxArtist.Text);
                ((List<Song>)catalog[diskName]).Add(song);
                listBoxOutput.Items.Add($"Пісню '{song.Title}' додано на диск '{diskName}'.");
            }
        }

        private void buttonRemoveSong_Click(object sender, EventArgs e)
        {
            string diskName = textBoxDisk.Text.Trim();
            if (catalog.ContainsKey(diskName))
            {
                var songs = (List<Song>)catalog[diskName];
                songs.RemoveAll(s => s.Title == textBoxTitle.Text && s.Artist == textBoxArtist.Text);
                listBoxOutput.Items.Add($"Пісню '{textBoxTitle.Text}' видалено з диска '{diskName}'.");
            }
        }

        private void buttonViewDisk_Click(object sender, EventArgs e)
        {
            string diskName = textBoxDisk.Text.Trim();
            listBoxOutput.Items.Clear();
            if (catalog.ContainsKey(diskName))
            {
                listBoxOutput.Items.Add($"Диск: {diskName}");
                foreach (var song in (List<Song>)catalog[diskName])
                {
                    listBoxOutput.Items.Add($"- {song.Title} ({song.Artist})");
                }
            }
        }

        private void buttonViewAll_Click(object sender, EventArgs e)
        {
            listBoxOutput.Items.Clear();
            foreach (DictionaryEntry entry in catalog)
            {
                listBoxOutput.Items.Add($"Диск: {entry.Key}");
                foreach (var song in (List<Song>)entry.Value)
                {
                    listBoxOutput.Items.Add($"- {song.Title} ({song.Artist})");
                }
            }
        }

        private void buttonSearchArtist_Click(object sender, EventArgs e)
        {
            string artist = textBoxArtist.Text.Trim();
            listBoxOutput.Items.Clear();
            foreach (DictionaryEntry entry in catalog)
            {
                foreach (var song in (List<Song>)entry.Value)
                {
                    if (song.Artist.Equals(artist, StringComparison.OrdinalIgnoreCase))
                        listBoxOutput.Items.Add($"[{entry.Key}] {song.Title} ({song.Artist})");
                }
            }
        }
    }

    public class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }

        public Song(string title, string artist)
        {
            Title = title;
            Artist = artist;
        }
    }
}
