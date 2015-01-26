class IsbnTester
  ISBN_REGEX = /^\d{9}[\d|x]$/i
  def self.test(isbn)
    tr_isbn = isbn.tr('-', '')
    if tr_isbn =~ ISBN_REGEX && self.perform_test(tr_isbn)
      p "#{isbn} is valid"
    else
      p "#{isbn} is not valid"
    end
  end

  private
  def self.perform_test(isbn)
    total = 0
    isbn.each_char.with_index do | value, index |
      value = 10 if value.casecmp('x') == 0
      total += (10 - index) * value.to_i
    end
    total % 11 == 0
  end
end

IsbnTester.test('1-23456-789x')
IsbnTester.test('1--48593-4548-789123')
IsbnTester.test('0-7475-3269-9')
IsbnTester.test('abcdefghix')
IsbnTester.test('x987654321')
IsbnTester.test('0-32164-9878')