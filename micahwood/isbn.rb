require_relative 'isbn/isbn_creator'
require_relative 'isbn/isbn_tester'

puts 'testing the validator with hard coded values'
Isbn::IsbnTester.test('1-23456-789x')
Isbn::IsbnTester.test('1--48593-4548-789123')
Isbn::IsbnTester.test('0-7475-3269-9')
Isbn::IsbnTester.test('abcdefghix')
Isbn::IsbnTester.test('x987654321')
Isbn::IsbnTester.test('0-32164-9878')

puts 'testing the creator'
(0..10).each { Isbn::IsbnTester.test(Isbn::IsbnCreator.create) }