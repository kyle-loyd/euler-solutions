fn main() {
    let mut current = 3;
    let mut sum = 0;
    loop {
        if current < 1000 {
            if current % 3 == 0 || current % 5 == 0 {
                sum += current;
            }
        }
        else {
            break;
        }
        current += 1;
    }
    println!("Answer: {}", sum);
}