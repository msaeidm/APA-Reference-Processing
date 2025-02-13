# Design Notes

This document explains the design and implementation choices for the APA Reference Processing modules.

## Overview

- **APAReferenceRemover**: Uses regular expressions to identify and remove APA references.
- **NamedEntityAnalyzer**: Uses a simple heuristic (capitalized words) to approximate named entity detection.
- **SentenceLengthAnalyzer**: Calculates average sentence length and computes deviation as a weight.
- **NumericEntityAnalyzer**: Counts numeric occurrences in sentences and computes a corresponding weight.

## Future Work

- Integrate more robust NLP libraries for named entity recognition.
- Improve regular expressions to cover more APA reference formats.
- Add unit tests and continuous integration.
