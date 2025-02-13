# APA-Reference-Processing

This repository contains a C# implementation of modules proposed in the article:

**Study of APA Referencing Challenges in Persian Scientific Text Processing**

The project includes code to:

- **Detect and Remove APA References**  
  Detect APA-style inter-textual references (e.g., `(Hedayati, 2015)` or `(Hedayati, et al, 2015; 7)`) and remove them from scientific texts.

- **Analyze Named Entities**  
  Compute a “named entity weight” for each sentence based on the number of detected entities relative to sentence length.

- **Analyze Sentence Length**  
  Calculate the average sentence length and compute a sentence length weight (the difference from the average).

- **Analyze Numeric Entities**  
  Compute a numeric entity weight based on the frequency of numbers in the sentence.

## Repository Structure

- **README.md**: This file with project overview, setup, and usage instructions.
- **LICENSE**: The project license (e.g., MIT License).
- **.gitignore**: To ignore build folders and other unneeded files.
- **docs/**: Contains additional documentation (e.g., design notes in `design.md`).
- **src/**: Contains all source code files:
  - `APAReferenceRemover.cs`: Module to remove APA references from text.
  - `NamedEntityAnalyzer.cs`: Module to detect and weigh named entities.
  - `SentenceLengthAnalyzer.cs`: Module to calculate sentence lengths and weights.
  - `NumericEntityAnalyzer.cs`: Module to detect and weigh numeric entities.
  - `Program.cs`: The main program to tie the modules together.
- **tests/**: Contains sample input files for testing the modules.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (for compiling and running the C# code)

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/yourusername/APA-Reference-Processing.git
   cd APA-Reference-Processing
