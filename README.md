# Dominata
Wyszukiwania najczęstszej wartości (ang. searching for the most frequent value), czyli tzw. dominanty zbioru, możemy rozwiązać na kilka różnych sposobów. Pierwszym, najprostszym podejściem jest metoda bezpośrednia:

Przeglądamy kolejne elementy zbioru i zliczamy liczbę wystąpień ich wartości w zbiorze. Można to robić tak – zapamiętujemy i-ty element i ustawiamy licznik wystąpień na 0. Następnie przeglądamy cały zbiór i, jeśli trafimy na element o takiej samej wartości, to licznik zwiększamy o 1. Po wykonaniu tej operacji porównujemy zawartość licznika z tymczasową maksymalną liczbą wystąpień (na początku algorytmu jest ona ustawiana na 0). Jeśli stan licznika jest większy, to zapamiętujemy go w tymczasowej maksymalnej liczbie wystąpień oraz zapamiętujemy wyszukiwaną wartość elementu. Gdy przeglądniemy w ten sposób i zliczymy wystąpienia wartości wszystkich elementów w zbiorze Z, to otrzymamy element powtarzający się najczęściej oraz ilość tych powtórzeń.

Waszym zadaniem jest utworzenie listy o rozmiarze podanym przez użytkownika oraz algorytmu dominaty zbioru

Na cel
Algorytm Depth-First Search (DFS) to jedna z podstawowych technik przeszukiwania grafów. Działa na zasadzie rekurencyjnego przeszukiwania struktury grafu poprzez odwiedzanie wierzchołków wzdłuż jednej z gałęzi grafu tak daleko, jak to możliwe, zanim wróci do poprzedniego wierzchołka i kontynuuje przeszukiwanie.
Oto kroki działania algorytmu DFS:
Wybór wierzchołka startowego: Wybieramy jeden z wierzchołków grafu jako punkt początkowy przeszukiwania. Możemy wybrać dowolny wierzchołek jako startowy.
Oznaczenie wierzchołka jako odwiedzony: Gdy odwiedzamy wierzchołek, oznaczamy go jako odwiedzony, aby uniknąć cyklicznych pętli i zapewnić, że nie odwiedzimy go ponownie.
Przeszukiwanie sąsiadów: Dla każdego sąsiada aktualnie odwiedzanego wierzchołka, który nie został jeszcze odwiedzony, wywołujemy rekurencyjnie algorytm DFS dla tego sąsiada. W ten sposób kontynuujemy przeszukiwanie w głąb każdej gałęzi grafu.
Powrót: Jeśli wszystkie sąsiednie wierzchołki aktualnego wierzchołka zostały już odwiedzone lub brak dalszych wierzchołków do odwiedzenia, wracamy do poprzedniego wierzchołka w grafie i kontynuujemy przeszukiwanie z tego punktu.
Kontynuacja przeszukiwania: Powtarzamy kroki 3-4 dla każdego nieodwiedzonego wierzchołka, aż odwiedzimy wszystkie wierzchołki grafu lub dotrzemy do końca gałęzi i nie będziemy mogli kontynuować dalej.
Algorytm DFS działa rekurencyjnie, przechodząc wzdłuż jednej gałęzi grafu tak daleko, jak to możliwe, zanim wróci do poprzedniego wierzchołka i rozważy inne gałęzie. Jest to proces głębokiego badania struktury grafu, który może być używany do wielu zadań, takich jak wykrywanie cykli w grafie, znajdowanie drzewa rozpinającego, topologiczne sortowanie wierzchołków oraz wiele innych.

Utwórz klasę graf która będzie reprezentować grafy, następnie zaimplementuj algorytm DFS w tej klasie i przetestuj jego działanie.
