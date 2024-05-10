# ds-tree-csharp

## Sub Capaian Pembelajaran

Mahasiswa mampu mengimplementasikan konsep struktur data binary search tree

## Lingkungan Pengembangan

1. Platform: .NET 6.0
2. Bahasa: C# 10
3. IDE: Visual Studio 2022

## Cara membuka project menggunakan Visual Studio

1. Clone repositori project `ds-tree-csharp` ke direktori lokal git Anda.
2. Buka Visual Studio, pilih menu File > Open > Project/Solution > Pilih file *.sln.
3. Tekan tombol Open untuk  untuk membuka solusi.
4. Baca soal dengan seksama. Buat implementasi kode sesuai dengan petunjuk.
6. Jalankan unit test di project *.Tests

> PERINGATAN: Push kode program ke remote repository jika hanya seluruh test case sudah lolos/passed (bertanda hijau).

## Soal-soal

### Soal 1: Implementasi Binary Search Tree (BST) di C#

Buat solusi dari soal ini di project `Solution` dalam folder `BST` dengan namespace `Solution.BST`.

#### Tujuan
Tujuan tugas ini adalah untuk memahami konsep dan implementasi BST dalam C#. Anda diminta untuk membuat implementasi `BinarySearchTree` yang mendukung operasi insert.

#### Persyaratan Tugas
1. **Kelas Node**
   - Buat kelas `Node` dalam C# yang memiliki properti:
     - `int Data` untuk menyimpan nilai node.
     - `Node Left` untuk referensi ke node anak kiri.
     - `Node Right` untuk referensi ke node anak kanan.
   - Sediakan konstruktor yang menginisialisasi `Data` dan set `Left` dan `Right` ke `null`.

2. **Kelas BinarySearchTree**
   - Buat kelas `BinarySearchTree` dengan properti private `Node root` yang akan menjadi root dari BST.
   - Implementasikan metode `Insert(int value)` untuk menambahkan nilai baru ke dalam BST dengan aturan sebagai berikut:
     - Jika `root` adalah `null`, buat `root` baru dengan nilai yang diberikan.
     - Jika nilai yang dimasukkan lebih kecil dari nilai node saat ini, masukkan ke subpohon kiri.
     - Jika nilai yang dimasukkan lebih besar, masukkan ke subpohon kanan.
     - Pastikan bahwa tidak ada duplikat nilai dalam pohon.
   - Implementasikan metode `Display()` yang mengembalikan nilai string yang berisi urutan inorder (kiri, root, kanan). Gunakan metode traversal inorder. Format stringnya adalah `[1, 2, 3, 4, 5, ...]`.

3. **Kelas Program**
   - Dalam kelas `Program` dan metode `Main`, demonstrasikan:
     - Pembuatan instance dari `BinarySearchTree`.
     - Penambahan beberapa nilai ke dalam pohon.
     - Tampilkan output dari pohon menggunakan metode `Display()` jika sudah diimplementasikan.

#### Contoh Kasus
Misalnya, jika nilai yang dimasukkan adalah `[15, 10, 20, 8, 12, 16, 25]`, pohon harus terbentuk dengan 15 sebagai root, 10 sebagai anak kiri dari 15, 20 sebagai anak kanan dari 15, dan seterusnya. Output dari metode `Display()` harus `8, 10, 12, 15, 16, 20, 25`.

### Soal 2: Menambahkan Breadth-First Traversal pada Binary Search Tree (BST)

Buat solusi dari soal ini di project `Solution` dalam folder `BST` dengan namespace `Solution.BST`.

#### Tujuan
Tugas ini bertujuan untuk melengkapi implementasi Binary Search Tree (BST) Anda dengan menambahkan fungsionalitas traversal breadth-first. Breadth-first traversal, atau level-order traversal, memproses node pada setiap level dari atas ke bawah dan dari kiri ke kanan.

#### Persyaratan Tugas
1. **Melanjutkan Kelas BinarySearchTree**
   - Tambahkan metode `BreadthFirstTraversal()` pada kelas `BinarySearchTree` yang Anda buat sebelumnya. Metode ini harus mencetak atau mengembalikan nilai dari setiap node dalam BST mengikuti urutan breadth-first.

2. **Implementasi Metode**
   - Metode `BreadthFirstTraversal()` yang mengembalikan string dengan format `[1, 2, 3, 4, 5, ...]` menggunakan struktur data antrian (Queue) untuk mencapai traversal level-order.
   - Mulai dengan menambahkan `root` ke dalam Queue.
   - Selama Queue tidak kosong, lakukan operasi berikut:
     - Keluarkan satu node dari Queue.
     - Akses nilai node tersebut.
     - Tambahkan node anak kiri ke Queue jika ada.
     - Tambahkan node anak kanan ke Queue jika ada.
   - Ulangi proses ini sampai Queue kosong.

3. **Kelas Program**
   - Dalam metode `Main` dari kelas `Program`, setelah membangun BST dengan beberapa elemen, demonstrasikan penggunaan `BreadthFirstTraversal()` untuk mencetak nilai dari setiap node dalam BST.

#### Contoh Implementasi
- Jika nilai yang dimasukkan adalah `[20, 10, 30, 5, 15, 25, 35]`, maka output dari `BreadthFirstTraversal()` harusnya:
  ```
  [20, 10, 30, 5, 15, 25, 35]
  ```
  Menunjukkan bahwa node telah diakses dari level atas ke bawah dan dari kiri ke kanan pada setiap level.

### Soal 3: Menambahkan Depth-First Traversal pada Binary Search Tree (BST)

Buat solusi dari soal ini di project `Solution` dalam folder `BST` dengan namespace `Solution.BST`.

#### Tujuan
Tugas ini bertujuan untuk memperluas fungsionalitas Binary Search Tree (BST) yang telah Anda bangun sebelumnya dengan menambahkan metode traversal depth-first yang meliputi preorder, inorder, dan postorder.

#### Persyaratan Tugas
1. **Melanjutkan Kelas BinarySearchTree**
   - Tambahkan metode `PreorderTraversal()`, `InorderTraversal()`, dan `PostorderTraversal()` pada kelas `BinarySearchTree` yang Anda buat sebelumnya. Metode ini harus mengembalikan nilai string dengan format `[1, 2, 3, 4, 5, ...]`  dari setiap node dalam BST sesuai dengan metode traversal yang sesuai.

2. **Implementasi Metode**
   - **Preorder Traversal**: Kunjungi node, lalu rekursif ke subtree kiri, dan rekursif ke subtree kanan.
   - **Inorder Traversal**: Rekursif ke subtree kiri, kunjungi node, lalu rekursif ke subtree kanan. Ini akan menghasilkan nilai dalam urutan yang terurut.
   - **Postorder Traversal**: Rekursif ke subtree kiri, rekursif ke subtree kanan, lalu kunjungi node.
   - Gunakan rekursi untuk implementasi ketiga metode tersebut. Setiap metode harus memulai traversal dari `root` dan mengakses node sesuai dengan urutan traversal yang diinginkan.

3. **Kelas Program**
   - Dalam metode `Main` dari kelas `Program`, setelah membangun BST, demonstrasikan penggunaan `PreorderTraversal()`, `InorderTraversal()`, dan `PostorderTraversal()` untuk mencetak nilai dari setiap node dalam BST.
   - Uji coba dengan input yang sama dan tampilkan hasil dari setiap metode traversal untuk memastikan bahwa mereka bekerja dengan benar.

#### Contoh Implementasi
- Misal, jika nilai yang dimasukkan adalah `[20, 10, 30, 5, 15, 25, 35]`, maka output dari masing-masing traversal harusnya:
  - **Preorder**: `[20, 10, 5, 15, 30, 25, 35]`
  - **Inorder**: `[5, 10, 15, 20, 25, 30, 35]` (menghasilkan nilai terurut)
  - **Postorder**: `[5, 15, 10, 25, 35, 30, 20]`

### Soal 4: Menambahkan Metode FindMinimum dan FindMaximum pada Binary Search Tree (BST) di C#

#### Tujuan
Setelah membangun Binary Search Tree (BST) dengan operasi insert, tugas lanjutan ini bertujuan untuk memperluas fungsionalitas BST dengan menambahkan metode untuk mencari elemen dengan nilai minimum dan maksimum dalam BST.

#### Persyaratan Tugas
1. **Melanjutkan Kelas BinarySearchTree**
   - Tambahkan dua metode baru pada kelas `BinarySearchTree` yang Anda buat sebelumnya:
     - `FindMinimum()`: Metode ini harus mengembalikan nilai terkecil dalam BST. Nilai terkecil pada BST terletak pada node paling kiri. Jika BST kosong, metode dapat melemparkan exception.
     - `FindMaximum()`: Metode ini harus mengembalikan nilai terbesar dalam BST, yang akan ditemukan pada node paling kanan. Sama seperti `FindMinimum`, jika BST kosong, lemparkan exception.

2. **Implementasi Metode**
   - Untuk `FindMinimum()`:
     - Mulai dari `root` dan lanjutkan ke node anak kiri sampai tidak ada anak kiri yang tersisa. Node terakhir yang ditemui akan memiliki nilai terkecil.
   - Untuk `FindMaximum()`:
     - Mulai dari `root` dan bergerak ke node anak kanan sampai tidak ada anak kanan yang tersisa. Node terakhir yang ditemui akan memiliki nilai terbesar.

3. **Kelas Program**
   - Dalam metode `Main` dari kelas `Program`, setelah menambahkan elemen ke dalam BST, demonstrasikan penggunaan `FindMinimum()` dan `FindMaximum()` untuk mencetak nilai minimum dan maksimum dalam BST.
   - Pastikan untuk menangani situasi ketika BST kosong dengan menampilkan pesan yang sesuai atau menghandle exception.

#### Contoh Implementasi
- Jika nilai yang dimasukkan adalah `[20, 10, 30, 5, 15, 25, 35]`, maka:
  - Output dari `FindMinimum()` harus `5`.
  - Output dari `FindMaximum()` harus `35`.

=== Selesai ===


