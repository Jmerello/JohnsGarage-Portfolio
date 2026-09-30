# John's Garage Architecture

John's Garage is organized as a Windows desktop business application with a relational domain model and dedicated UI areas for the shop workflow.

## Core workflow

```text
Customer
   └── Vehicle
        └── Repair Order
             ├── Parts
             └── Labor
```

The same operational data feeds higher-level features such as open-repair-order views, parts-order tracking, invoice workflows, and dashboard summaries.

## Persistence

The production application uses Entity Framework Core with SQLite. Relationships use explicit foreign keys and cascade behavior so customer, vehicle, repair-order, parts, and labor records remain structurally connected.

The production database, customer records, local storage paths, migration/compatibility details, and operational configuration are not included in this portfolio repository.

## Application areas

- Dashboard and shop-level status
- Customer and vehicle management
- Repair-order workflow
- Parts and labor tracking
- Parts-order visibility
- Invoice workflow
- Shop settings and pricing configuration
- Embedded access to external automotive service and supplier resources

## Portfolio boundary

This repository intentionally contains representative code excerpts rather than the complete production application. It demonstrates the domain model, relational design, calculated business values, and overall product architecture without publishing customer data or proprietary implementation details.
